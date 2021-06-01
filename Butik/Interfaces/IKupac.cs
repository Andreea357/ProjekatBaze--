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
    public interface IKupac
    {

        [OperationContract]
        bool AddCustomer(KupacIM kupac);
        [OperationContract]
        List<KupacIM> GetAllCustomers();
        [OperationContract]
        bool ChangeCustomer(KupacIM kupac);
        [OperationContract]
        bool DeleteCustomer(int idProdavca);
    }
}
