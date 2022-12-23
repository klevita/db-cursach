using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсовой_проект.entity
{
    //Определение отношение диаметра меньшего шкива к толщине ремня D/δ
    public class Table1
    {
        //вид материала
        public string TypeMaterial { get; set; }
        //Допускаемое отношение диаметра меньшего шкива к толщине ремня
        public double AcceptableRatio { get; set; }
        //Рекомендуемое отношение диаметра меньшего шкива к толщине ремня
        public double RecommendedRatio { get; set; }

        public Table1()
        {

        }
        public Table1(string TypeMaterial, double AcceptableRatio, double RecommendedRatio)
        {
            this.TypeMaterial = TypeMaterial;
            this.AcceptableRatio = AcceptableRatio;
            this.RecommendedRatio = RecommendedRatio;
        }
    }
}
