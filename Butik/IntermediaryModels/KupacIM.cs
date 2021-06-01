using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Butik.IntermediaryModels
{
    [DataContract]
    public class KupacIM
    {
        [DataMember]
        public int IdKupca { get; set; }
        
    }
}
