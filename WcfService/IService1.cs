using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени интерфейса "IService1" в коде и файле конфигурации.
    [ServiceContract]
    public interface ICalculatorSevice
    {

        [OperationContract]
        string dodawanie4Param(double rz_1, double ur_1, double rz_2, double ur_2);

        [OperationContract]
        string odejmowanie4Param(double rz_1, double ur_1, double rz_2, double ur_2);

        [OperationContract]
        string mnozenie4Param(double rz_1, double ur_1, double rz_2, double ur_2);

        [OperationContract]
        string dzielenie4Param(double rz_1, double ur_1, double rz_2, double ur_2);

        ///

        [OperationContract]
        string dodawanie2Param(ComplexType Zes_1, ComplexType Zes_2);

        [OperationContract]
        string odejmowanie2Param(ComplexType Zes_1, ComplexType Zes_2);

        [OperationContract]
        string mnozenie2Param(ComplexType Zes_1, ComplexType Zes_2);

        [OperationContract]
        string dzielenie2Param(ComplexType Zes_1, ComplexType Zes_2);
    }


    // Используйте контракт данных, как показано в примере ниже, чтобы добавить составные типы к операциям служб.

    [DataContract]
    public class ComplexType
    {
        double ur;
        double rz;

        [DataMember]
        public double Rzeczewista
        {
            get { return rz; }
            set { rz = value; }
        }

        [DataMember]
        public double Urojona
        {
            get { return ur; }
            set { ur = value; }
        }
    }
}
