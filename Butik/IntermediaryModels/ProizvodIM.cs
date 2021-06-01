using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Butik.IntermediaryModels
{
    [DataContract]
    public class ProizvodIM
    {
        [DataMember]
        public int KodProizvoda { get; set; }
        [DataMember]
        public int Cijena { get; set; }
        [DataMember]
        public string NazivProizvoda { get; set; }
    }
}
