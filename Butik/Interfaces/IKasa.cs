using Butik.IntermediaryModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Butik.Interfaces
{
    [ServiceContract]
    public interface IKasa
    {
        [OperationContract]
        bool AddAllCashRegister(KasaIM kasa);
        [OperationContract]
        bool ChangeAllCashRegister(KasaIM kasa);
        [OperationContract]
        bool DeleteAllCashRegister(int idkase);
        [OperationContract]
        List<KasaIM> GetAllCashRegister();
    }
}
