using Butik.Interfaces;
using Butik.IntermediaryModels;
using ProjekatBaze;
using ProjekatBaze.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Butik.Services
{
    class RadnikService : IRadnik
    {
        private static RadnikDA dao = new RadnikDA();

        public bool AddWorker(RadnikIM radnik)
        {

            Radnik k = new Radnik()
            {
                JMBG = radnik.JMBG,
                ImeRadnika = radnik.ImeRadnika,
                PrezimeRadnika = radnik.PrezimeRadnika,
            
            };


            return dao.Insert(k);
        }

        public bool ChangeWorker(RadnikIM radnik)
        {
            Radnik d = dao.FindById(radnik.JMBG);
            d.JMBG = radnik.JMBG;
            d.PrezimeRadnika = radnik.PrezimeRadnika;
            d.ImeRadnika = radnik.ImeRadnika;


            return dao.Update(d);
        }

        public bool DeleteWorker(int idRadnika)
        {
            return dao.Delete(idRadnika);
        }

        public List<RadnikIM> GetAllWorkers()
        {

            List<Radnik> lista = dao.GetAll();
            List<RadnikIM> retVal = new List<RadnikIM>();
            foreach (var item in lista)
            {
                retVal.Add(new RadnikIM() { JMBG = item.JMBG,ImeRadnika=item.ImeRadnika,PrezimeRadnika=item.PrezimeRadnika });
            }
            return retVal;
        }
    }
}
