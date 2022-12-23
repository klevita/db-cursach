using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсовой_проект.model
{
    public static class StaticData
    {
        public static readonly string[] TypeMaterial = new string[2] 
        { 
            "Тканевые прорезиненные конечной формы", 
            "Синтетические капроновые с пленочным покрытием" 
        };

        public static readonly string[] Material = new string[2]
        {
            "Прорезиненный",
            "Синтетический"
        };

        public static readonly string[] TypeTransmission = new string[2]
        {
            "Повышающая передача",
            "Понижающая передача"
        };

        public static readonly string[] TypeTransmissionStroke = new string[2]
        {
            "Среднескоростная передача",
            "Быстроскоростная передача"
        };

        public static readonly string[] TypeDminDelta = new string[2]
        {
            "Допускаемое",
            "Рекомендуемое"
        };

        public static readonly string[] TypeCalcul_L = new string[2]
        {
            "По выбранному межосевому расстоянию",
            "Из условий сравнительной долговечности ремня"
        };
    }
}
