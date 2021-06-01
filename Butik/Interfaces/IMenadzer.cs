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
    public interface IMenadzer
    {
        [OperationContract]
        bool Addmanager(MenadzerIM menadzer);
        [OperationContract]
        List<MenadzerIM> GetAllmanagers();
        [OperationContract]
        bool Changemanager(MenadzerIM menadzer);
        [OperationContract]
        bool Deletemanager(int menadzer);
    }
}
