using Butik.Interfaces;
using Butik;
using Butik.IntermediaryModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjekatBaze;
using ProjekatBaze.Data;

namespace Butik.Services
{
    class KasaService : IKasa
    {
        private static KasaDA dao = new KasaDA();
        public bool AddAllCashRegister(KasaIM kasa)
        {
            Kasa k = new Kasa()
            {
                IdKase = kasa.IdKase,
            };

        
            return dao.Insert(k);
        }

     
        public bool ChangeAllCashRegister(KasaIM kasa)
        {
            Kasa d = dao.FindById(kasa.IdKase);
            d.IdKase = kasa.IdKase;
         

            return dao.Update(d);
        }

        public bool DeleteAllCashRegister(int idkase)
        {
            return dao.Delete(idkase);
        }

        public List<KasaIM> GetAllCashRegister()
        {
            List<Kasa> lista = dao.GetAll();
            List<KasaIM> retVal = new List<KasaIM>();
            foreach (var item in lista)
            {
                retVal.Add(new KasaIM() { IdKase = item.IdKase });
            }
            return retVal;
        }
    }
}
