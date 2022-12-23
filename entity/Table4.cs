using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсовой_проект.entity
{
    //Определение коэффициента C_2
    public class Table4
    {
        //Материал
        public string Material { get; set; }
        //Скорость ремня v, м/с
        public double V { get; set; }
        //С2
        public double? C2 { get; set; }
        public Table4()
        {

        }
        public Table4(string Material, double V, double? C2)
        {
            this.Material = Material;
            this.V = V;
            this.C2 = C2;
        }
    }
}
