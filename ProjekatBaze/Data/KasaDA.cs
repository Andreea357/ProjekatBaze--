using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatBaze.Data
{
    public class KasaDA : Repository<Kasa>
    {
        public List<Kasa> FindByRadnikId(int idradnika)
        {
            using (var db = new Model1Container1())
            {
                Radnik zaposleni = db.Radniks.Find(idradnika);
                if (zaposleni != null)
                {
                    //return zaposleni.JMBG.ToString();
                }
                return new List<Kasa>();
            }
        }
    }
}
