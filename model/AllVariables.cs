using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсовой_проект.model
{
    //все переменные в курсовом проекте
    public class AllVariables
    {
        //открываешь декомпозицию, раздел параметры и переносишь все парметры сюда, кроме 
        //количества передача (KOL), счетчика (i), массива параметров передач (а, {a})
        //старайся, не изменять названия параметров, чтоб можно было понять что это, если смотреть в декомпозицию

        //все наименования, типs, материалs - это тип string
        //все числа - это тип float

        //код сборочной единицы
        public Guid CodeSE { get; set; }
        //Диаметр меньшего шкива
        public double D1 { get; set; }
        //Диаметр большего шкива
        public double D2 { get; set; }
        //Мощность
        public double N { get; set; }
        //Частота вращения меньшего шкива
        public int n1 { get; set; }
        //Частота вращения большего шкива
        public int n2 { get; set; }
        //Передаточное число
        public double u { get; set; }
        //Коэффициент скольжения ремня
        public double E { get; set; }
        //Тип передачи
        public string TypeTransmission { get; set; }
        //Скорость ремня
        public double V { get; set; }
        //Типа хода передачи
        public string TypeTransmissionStroke { get; set; }
        //Коэффициент, зависящий от типа хода передачи
        public double K_speed { get; set; }
        //Межосевое расстояние
        public double aMIN { get; set; }
        //Длина ремня
        public double L { get; set; }
        //Средний диаметр шкива
        public double Dcp { get; set; }
        //Коэффциент, связанный с диаметрами шкивов
        public double delta { get; set; }
        //Коэффициент, связанный с межосевым расстоянием
        public double lambda { get; set; }
        //межосевое расстояние
        public double a { get; set; }
        //Частота пробега ремня в секунду
        public double I { get; set; }
        //Тип расчета межосевого расстояния
        public string TypeCalcul_L { get; set; }
        //Угол обхвата меньшего шкива
        public double alpha { get; set; }
        //Коэффициент отношения диаметра меньшего шкива к толщине ремня
        public double K { get; set; }
        //Толщина ремня
        public double delta_belt { get; set; }
        //Окружающая сила
        public double F { get; set; }
        //Начальное напряжение ремня
        public double sigma_0 { get; set; }
        //Коэффициент
        public double A { get; set; }
        //Коэффициент
        public double W { get; set; }
        //Начальное напряжение ремня
        public double delta_0 { get; set; }
        //Материал и покрытие ремней
        public string Material { get; set; }
        //Приведенное полезное напряжение
        public double sigma_F_0 { get; set; }
        //Угол обхвата
        public double gamma { get; set; }
        //Коэффициент, зависящий от расположения передачи в пространстве и способа натяжения ремня
        public double C0 { get; set; }
        //Коэффициент, учитывающий влияние угла обхвата на меньшем шкиве
        public double C1 { get; set; }
        //Коэффициент, учитывающий влияние центробежной силы
        public double C2 { get; set; }
        //Коэффициент, учитывающий режим работы передачи
        public double C3 { get; set; }
        //Допускаемое полезное напряжение
        public double sigma_F { get; set; }
        //Ширина ремня по полезному напряжению
        public double b { get; set; }
        //Тип отношения диаметра меньшего шкива к толщине ремня
        public string TypeDminDelta { get; set; }
        //Вид материала 
        public string TypeMaterial { get; set; }

        public AllVariables()
        {

        }
    }
}
