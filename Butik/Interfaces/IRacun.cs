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
    public interface IRacun
    {
        [OperationContract]
        bool AddBill(RacunIM racun);
        [OperationContract]
        List<RacunIM> GetAllBills();
        [OperationContract]
        bool ChangeBill(RacunIM racun);
        [OperationContract]
        bool DeleteBill(int idracuna);
    }
}
