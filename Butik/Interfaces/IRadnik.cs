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
    public interface IRadnik
    {
        [OperationContract]
        bool AddWorker(RadnikIM radnik);
        [OperationContract]
        List<RadnikIM> GetAllWorkers();
        [OperationContract]
        bool ChangeWorker(RadnikIM radnik);
        [OperationContract]
        bool DeleteWorker(int idRadnika);
    }
}
