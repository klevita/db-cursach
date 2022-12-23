using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсовой_проект.entity
{
    //Определение значений коэффициентов А и W
    public class Table2
    {
        //Материал
        public string Material { get; set; }
        //Начальное напряжение δ_0, МПа
        public double InitialStress { get; set; }
        //А
        public double A { get; set; }
        //W
        public double W { get; set; }
        public Table2()
        {

        }
        public Table2(string Material, double InitialStress, double A, double W)
        {
            this.Material = Material;
            this.InitialStress = InitialStress;
            this.A = A;
            this.W = W;
        }
    }
}
