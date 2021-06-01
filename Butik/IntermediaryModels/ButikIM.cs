using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Butik.IntermediaryModels
{
    [DataContract]
    public class ButikIM
    {
        [DataMember]
        public int PIB { get; set; }
        [DataMember]
        public string Adresa { get; set; }
        [DataMember]
        public string Naziv { get; set; }
    }
}
