using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсовой_проект.entity
{
    //Определение коэффициента C_1
    public class Table3
    {
        //Угол обхвата gamma, град
        public double gamma { get; set; }
        //Коэффициент C_1
        public double C1 { get; set; }
        public Table3()
        {

        }
        public Table3(double gamma, double C1)
        {
            this.gamma = gamma;
            this.C1 = C1;
        }
    }
}
