using Butik.Interfaces;
using Butik.IntermediaryModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjekatBaze.Data;
using ProjekatBaze;

namespace Butik.Services
{
    class KupacService : IKupac
    {
        private static KupacDA dao = new KupacDA();
        public bool AddCustomer(KupacIM kupac)
        {
            Kupac ki = new Kupac()
            {
                IdKupca = kupac.IdKupca,
            };


            return dao.Insert(ki);
        }

        public bool ChangeCustomer(KupacIM kupac)
        {
            Kupac d = dao.FindById(kupac.IdKupca);
            d.IdKupca = kupac.IdKupca;


            return dao.Update(d);
        }

        public bool DeleteCustomer(int idProdavca)
        {

            return dao.Delete(idProdavca);
        }

        public List<KupacIM> GetAllCustomers()
        {
            List<Kupac> lista = dao.GetAll();
            List<KupacIM> retVal = new List<KupacIM>();
            foreach (var item in lista)
            {
                retVal.Add(new KupacIM() { IdKupca = item.IdKupca });
            }
            return retVal;
        }
    }
}
