using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Курсовой_проект.entity;
using Курсовой_проект.model;

namespace Курсовой_проект.Manager
{
    public class Decision
    {
        private List<AllVariables> alldata;
        private readonly DataDaseContext dbContext;

        public Decision(DataDaseContext dbContext, List<AllVariables> alldata)
        {
            this.alldata = alldata;
            this.dbContext = dbContext;
        }

        //ищем близкое  значение, таблица 2
        private Table2 Find_AW(List<Table2> list, double a)
        {
            double min = list[0].InitialStress;
            foreach (var n in list)
            {
                if ((Math.Abs(n.InitialStress - a)) < (Math.Abs(a - min)))
                {
                    min = n.InitialStress;
                }
            }
            return list.FirstOrDefault(g => g.InitialStress == min);
        }

        //ищем близкое  значение, таблица 3
        private Table3 Find_C1(List<Table3> list, double a)
        {
            double min = list[0].gamma;
            foreach (var n in list)
            {
                if ((Math.Abs(n.gamma - a)) < (Math.Abs(a - min)))
                {
                    min = n.gamma;
                }
            }
            return list.FirstOrDefault(g => g.gamma == min);
        }

        //ищем близкое  значение, таблица 4
        private Table4 Find_C2(List<Table4> list, double a)
        {
            double min = list[0].V;
            foreach (var n in list)
            {
                if ((Math.Abs(n.V - a)) < (Math.Abs(a - min)))
                {
                    min = n.V;
                }
            }
            return list.FirstOrDefault(g => g.V == min);
        }

        //проектировочный расчет
        public List<AllVariables> Result()
        {
            for (int i = 0; i < alldata.Count; i++) {
                //D1
                alldata[i].D1 = 120 * Math.Pow(alldata[i].N * 1000 / alldata[i].n1, 1.0 / 3.0);

                //u
                alldata[i].u = alldata[i].n1 / alldata[i].n2;

                //D2 - повышающая передача
                if (StaticData.TypeTransmission[0] == alldata[i].TypeTransmission)
                {
                    alldata[i].D2 = (alldata[i].D1 * alldata[i].u) / (1 - alldata[i].E);
                }
                else
                {
                    //D2 - понижающая передача
                    alldata[i].D2 = alldata[i].D1 * (1 - alldata[i].E) * alldata[i].u;
                }

                //округление D1 и D2
                alldata[i].D1 = Math.Round(alldata[i].D1, 0);
                alldata[i].D2 = Math.Round(alldata[i].D2, 0);

                //V
                alldata[i].V = (Math.PI * alldata[i].D1 * alldata[i].n1) / (1000 * 60.0);

                //a(min)
                alldata[i].aMIN = alldata[i].K_speed * (alldata[i].D1 + alldata[i].D2);

                //L - по выбранному межосевому расстоянию
                if(StaticData.TypeCalcul_L[0] == alldata[i].TypeCalcul_L)
                {
                    alldata[i].L = 2 * alldata[i].aMIN + Math.PI * (alldata[i].D1 + alldata[i].D2) / 2 + Math.Pow(alldata[i].D2 - alldata[i].D1, 2) / (4 * alldata[i].aMIN);
                }
                else
                {
                    //L - из условий сравнительной долговечности ремня
                    alldata[i].L = alldata[i].V / alldata[i].I;
                }

                //Dcp
                alldata[i].Dcp = (alldata[i].D1 + alldata[i].D2) / 2;

                //delta
                alldata[i].delta = (alldata[i].D2 - alldata[i].D1) / 2;

                //lambda
                alldata[i].lambda = alldata[i].L - Math.PI * alldata[i].Dcp;

                //a
                alldata[i].a = (alldata[i].lambda + Math.Pow(alldata[i].lambda * alldata[i].lambda - 8 * alldata[i].delta * alldata[i].delta, 1.0 / 2.0)) / 4;

                //alpha
                alldata[i].alpha = 180 - ((alldata[i].D2 - alldata[i].D1) / alldata[i].a) * 57;

                //alpha для прорезиненный
                if(StaticData.Material[0] == alldata[i].Material)
                {
                    if(alldata[i].alpha < 150)
                    {
                        alldata[i].alpha = 150;
                    }
                }
                else
                {
                    //alpha для синтетических
                    if(alldata[i].alpha < 120)
                    {
                        alldata[i].alpha = 120;
                    }
                }

                //K(Dmin/delta_belt) - таблица 1
                Table1 table1 = dbContext.table1.FirstOrDefault(g => g.TypeMaterial == alldata[i].TypeMaterial);
                //допускаемое
                if(StaticData.TypeDminDelta[0] == alldata[i].TypeDminDelta)
                {
                    alldata[i].K = table1.AcceptableRatio;
                }
                else
                {
                    alldata[i].K = table1.RecommendedRatio;
                }

                //delta_belt
                alldata[i].delta_belt = alldata[i].D1 / alldata[i].K;

                //F
                alldata[i].F = 1000 * alldata[i].N / alldata[i].V;

                //A - таблица 2 и W - таблица 2
                List<Table2> table2 = dbContext.table2.Where(g => g.Material == alldata[i].Material).ToList();
                Table2 tabl2_cell = Find_AW(table2, alldata[i].delta_0);

                alldata[i].A = tabl2_cell.A;
                alldata[i].W = tabl2_cell.W;

                //sigma_F_0
                alldata[i].sigma_F_0 = alldata[i].A - alldata[i].W * alldata[i].delta_belt / alldata[i].D1;

                //C1 - таблица 3
                alldata[i].C1 = Find_C1(dbContext.table3, alldata[i].gamma).C1;

                //C2 - таблица 4
                List<Table4> table4 = dbContext.table4.Where(g => g.Material == alldata[i].Material && g.C2 != null).ToList();
                alldata[i].C2 = (double)Find_C2(table4, alldata[i].V).C2;

                //sigma_F
                alldata[i].sigma_F = alldata[i].sigma_F_0 * alldata[i].C0 * alldata[i].C1 * alldata[i].C2 * alldata[i].C3;

                //b
                alldata[i].b = alldata[i].F / (alldata[i].delta_belt * alldata[i].sigma_F);
            }

            return alldata;
        }
    }
}

