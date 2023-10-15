using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени класса "Service1" в коде, SVC-файле и файле конфигурации.
    // ПРИМЕЧАНИЕ. Чтобы запустить клиент проверки WCF для тестирования службы, выберите элементы Service1.svc или Service1.svc.cs в обозревателе решений и начните отладку.
    public class Calculator : ICalculatorSevice
    {
        public string showResult(double rz, double ur)
        {
            if (rz == 0 && ur == 0)
                return "0";

            string result = "";

            if (rz != 0)
                result += rz.ToString();

            if (ur != 0)
            {
                if (ur > 0)
                    result += "+" + ur.ToString() + "i";
                else
                    result += ur.ToString() + "i";
            }

            return result;
        }

        public string dodawanie4Param(double rz_1, double ur_1, double rz_2, double ur_2)
        {
            double rz = rz_1 + rz_2;
            double ur = ur_1 + ur_2;
            return showResult(rz, ur);
        }

        public string odejmowanie4Param(double rz_1, double ur_1, double rz_2, double ur_2)
        {
            double rz = rz_1 - rz_2;
            double ur = ur_1 - ur_2;
            return showResult(rz, ur);
        }

        public string mnozenie4Param(double rz_1, double ur_1, double rz_2, double ur_2)
        {
            double rz = rz_1 * rz_2 - (ur_1 * ur_2);
            double ur = rz_1 * ur_2 + ur_1 * rz_2;
            return showResult(rz, ur);
        }

        public string dzielenie4Param(double rz_1, double ur_1, double rz_2, double ur_2)
        {
            double rz = ((rz_1 * rz_2) + (ur_1 * ur_2)) / (Math.Pow(rz_2, 2) + Math.Pow(ur_2, 2));
            double ur = ((ur_1 * rz_2) - (rz_1 * ur_2)) / (Math.Pow(rz_2, 2) + Math.Pow(ur_2, 2));
            return showResult(rz, ur);
        }

        ///

        public string dodawanie2Param(ComplexType Zes_1, ComplexType Zes_2)
        {
            return dodawanie4Param(Zes_1.Rzeczewista, Zes_1.Urojona, Zes_2.Rzeczewista, Zes_2.Urojona);
        }

        public string odejmowanie2Param(ComplexType Zes_1, ComplexType Zes_2)
        {
            return odejmowanie4Param(Zes_1.Rzeczewista, Zes_1.Urojona, Zes_2.Rzeczewista, Zes_2.Urojona);
        }

        public string mnozenie2Param(ComplexType Zes_1, ComplexType Zes_2)
        {
            return mnozenie4Param(Zes_1.Rzeczewista, Zes_1.Urojona, Zes_2.Rzeczewista, Zes_2.Urojona);
        }

        public string dzielenie2Param(ComplexType Zes_1, ComplexType Zes_2)
        {
            return dzielenie4Param(Zes_1.Rzeczewista, Zes_1.Urojona, Zes_2.Rzeczewista, Zes_2.Urojona);
        }
    }
}
