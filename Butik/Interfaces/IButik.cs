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
    public interface IButik
    {

        [OperationContract]
        bool AddBoutique(ButikIM  butik);
        [OperationContract]
        List<ProizvodIM> GetAllBoutique();
        [OperationContract]
        bool ChangeBoutiques(ButikIM butik);
        [OperationContract]
        bool DeleteBoutique(int idButika);
    }
}
