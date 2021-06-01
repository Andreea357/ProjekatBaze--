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
    public interface IProdavac
    {
        [OperationContract]
        bool Addseller(ProdavacIM prodavac);
        [OperationContract]
        List<ProdavacIM> GetAllsellers();
        [OperationContract]
        bool Changeseller(ProdavacIM prodavac);
        [OperationContract]
        bool Deleteseller(int idProdavca);
    }
}
