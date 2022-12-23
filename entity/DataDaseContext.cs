using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсовой_проект.entity
{
    public class DataDaseContext
    {
        public List<Table1> table1 { get; set; }
        public List<Table2> table2 { get; set; }
        public List<Table3> table3 { get; set; }
        public List<Table4> table4 { get; set; }
        public DataDaseContext()
        {
            //f - на конце каждого числа означает, что тип float

            //заполняем таблицу 1 
            table1 = new List<Table1>();
            table1.Add(new Table1("Тканевые прорезиненные конечной формы", 30f, 40f));
            table1.Add(new Table1("Синтетические капроновые с пленочным покрытием", 50f, 100f));

            //заполняем таблицу 2
            table2 = new List<Table2>();
            table2.Add(new Table2("Прорезиненный", 1.6f, 2.3f, 9.0f));
            table2.Add(new Table2("Прорезиненный", 1.8f, 2.5f, 10.0f));
            table2.Add(new Table2("Прорезиненный", 2.0f, 2.7f, 11.0f));
            table2.Add(new Table2("Прорезиненный", 2.4f, 3.05f, 13.5f));
            table2.Add(new Table2("Синтетический", 4.0f, 5.75f, 176f));
            table2.Add(new Table2("Синтетический", 4.0f, 6.55f, 124f));
            table2.Add(new Table2("Синтетический", 5.0f, 7.0f, 220f));
            table2.Add(new Table2("Синтетический", 5.0f, 8.0f, 156f));
            table2.Add(new Table2("Синтетический", 7.5f, 9.6f, 330f));
            table2.Add(new Table2("Синтетический", 7.5f, 11.4f, 233f));
            table2.Add(new Table2("Синтетический", 10.0f, 11.6f, 440f));
            table2.Add(new Table2("Синтетический", 11.0f, 14.3f, 311f));

            //заполняем таблицу 3
            table3 = new List<Table3>();
            table3.Add(new Table3(110f, 0.79f));
            table3.Add(new Table3(120f, 0.82f));
            table3.Add(new Table3(130f, 0.85f));
            table3.Add(new Table3(140f, 0.88f));
            table3.Add(new Table3(150f, 0.91f));
            table3.Add(new Table3(160f, 0.94f));
            table3.Add(new Table3(170f, 0.97f));
            table3.Add(new Table3(180f, 1.0f));

            //заполняем таблицу 4
            //если в графе стоит прочерк, то ставь null
            //пример table4.Add(new Table4("Прорезиненный", 10f, null));
            table4 = new List<Table4>();
            table4.Add(new Table4("Прорезиненный", 5f, 1.03f));
            table4.Add(new Table4("Прорезиненный", 10f, 1.00f));
            table4.Add(new Table4("Прорезиненный", 15f, 0.95f));
            table4.Add(new Table4("Прорезиненный", 20f, 0.88f));
            table4.Add(new Table4("Прорезиненный", 25f, 0.79f));
            table4.Add(new Table4("Прорезиненный", 30f, 0.68f));
            table4.Add(new Table4("Прорезиненный", 35f, null));
            table4.Add(new Table4("Прорезиненный", 40f, null));
            table4.Add(new Table4("Прорезиненный", 50f, null));
            table4.Add(new Table4("Прорезиненный", 70f, null));

            table4.Add(new Table4("Синтетический", 5f, 1.01f));
            table4.Add(new Table4("Синтетический", 10f, 1.0f));
            table4.Add(new Table4("Синтетический", 15f, 0.99f));
            table4.Add(new Table4("Синтетический", 20f, 0.97f));
            table4.Add(new Table4("Синтетический", 25f, 0.95f));
            table4.Add(new Table4("Синтетический", 30f, 0.92f));
            table4.Add(new Table4("Синтетический", 35f, 0.89f));
            table4.Add(new Table4("Синтетический", 40f, 0.85f));
            table4.Add(new Table4("Синтетический", 50f, 0.76f));
            table4.Add(new Table4("Синтетический", 70f, 0.52f));

        }

    }
}
