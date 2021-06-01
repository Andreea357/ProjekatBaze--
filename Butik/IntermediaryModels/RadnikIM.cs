using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Butik.IntermediaryModels
{
    [DataContract]
    public class RadnikIM
    {
        [DataMember]
        public int JMBG { get; set; }
        [DataMember]
        public string ImeRadnika { get; set; }
        [DataMember]
        public string PrezimeRadnika { get; set; }
    }
}
