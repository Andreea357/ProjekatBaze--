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
    public interface IKupuje
    {
      //  [OperationContract]
     //   List<KupujeIM> GetRadoviForKontrolnaTacka(int idZaposlenog, int idKT);

        [OperationContract]
        bool ChangeRad(KupujeIM kupuje);
    }
}
