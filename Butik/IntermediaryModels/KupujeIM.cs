using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Butik.IntermediaryModels
{
    [DataContract]
    public class KupujeIM
    {
        [DataMember]
        public int ID { get; set; }
        [DataMember]
        public int KupacIdKupca { get; set; }
        [DataMember]
        public int ProizvodKodProizvoda { get; set; }
        [DataMember]
        public int RacunIdRacuna { get; set; }
    }
}
