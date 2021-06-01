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
    public interface IProizvod
    {
        [OperationContract]
        bool AddProduct(ProizvodIM proizvod);
        [OperationContract]
        List<ProizvodIM> GetProductFromBoutique(int idbutika);
        [OperationContract]
        bool ChangeProduct(ProizvodIM  proizvod);
        [OperationContract]
        bool DeleteProduct(int idproiz);
    }
}
