using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсовой_проект.model
{
    public class AllVariableTex
    {
        public List<String> AllVariable { get; } = new List<string>();

        //здесь симпольно опиши каждый параметр используемый в декомпозиции
        public readonly string CodeSE = "CodeSE";
        public readonly string D1 = "Вид колес";
        public readonly string D2 = "Материал шестерни";
        public readonly string N = "Материала колес";
        public readonly string n1 = "Материал и марки";
        public readonly string n2 = "Количество передач";
        public readonly string u = "u";
        public readonly string E = "E";
        public readonly string TypeTransmission = "Крутящий момент";
        public readonly string V = "V";
        public readonly string TypeTransmissionStroke = "Число зубьев";
        public readonly string K_speed = "Диаметр шестерни";
        public readonly string aMIN = "a(min)";
        public readonly string L = "L";
        public readonly string Dcp = "Dcp";
        public readonly string delta = "delta";
        public readonly string lambda = "lambda";
        public readonly string I = "I";
        public readonly string TypeCalcul_L = "TypeCalcul_L";
        public readonly string alpha = "alpha";
        public readonly string K = "K(Dmin/delta_belt)";
        public readonly string delta_belt = "delta_belt";
        public readonly string F = "F";
        public readonly string sigma_0 = "sigma_0";
        public readonly string A = "A";
        public readonly string W = "W";
        public readonly string delta_0 = "delta_0";
        public readonly string Material = "Material";
        public readonly string sigma_F_0 = "[sigma_F]_0";
        public readonly string gamma = "gamma";
        public readonly string C0 = "C0";
        public readonly string C1 = "C1";
        public readonly string C2 = "C2";
        public readonly string C3 = "C3";
        public readonly string sigma_F = "[sigma_F]";
        public readonly string b = "b";
        public readonly string TypeDminDelta = "Type(Dmin/delta_belt)";
        public readonly string TypeMaterial = "TypeMaterial";
        public readonly string a = "a";

        public AllVariableTex()
        {
            //а потои загони в список ALLVariable
            AllVariable.Add(CodeSE);
            AllVariable.Add(TypeMaterial);
            AllVariable.Add(Material);
            AllVariable.Add(n1);
            AllVariable.Add(n2);
            AllVariable.Add(K_speed);
            AllVariable.Add(C0);
            AllVariable.Add(C3);
            AllVariable.Add(TypeTransmission);
            AllVariable.Add(TypeTransmissionStroke);
            AllVariable.Add(TypeDminDelta);
            AllVariable.Add(TypeCalcul_L);
            AllVariable.Add(N);
            AllVariable.Add(I);
            AllVariable.Add(sigma_0);
            AllVariable.Add(delta_0);
            AllVariable.Add(gamma);
            AllVariable.Add(E);

            AllVariable.Add(D1);
            AllVariable.Add(u);
            AllVariable.Add(D2);
            AllVariable.Add(V);
            AllVariable.Add(aMIN);
            AllVariable.Add(L);
            AllVariable.Add(Dcp);
            AllVariable.Add(delta);
            AllVariable.Add(lambda);
            AllVariable.Add(a);
            AllVariable.Add(alpha);
            AllVariable.Add(K);
            AllVariable.Add(delta_belt);
            AllVariable.Add(F);
            AllVariable.Add(A);
            AllVariable.Add(W);
            AllVariable.Add(sigma_F_0);
            AllVariable.Add(C1);
            AllVariable.Add(C2);
            AllVariable.Add(sigma_F);
            AllVariable.Add(b);
        }
    }
}
