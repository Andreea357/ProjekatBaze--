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
    class RacunService : IRacun
    {
        private static RacunDA dao = new RacunDA();

        public bool AddBill(RacunIM racun)
        {
            Racun k = new Racun()
            {
                IdRacuna = racun.IdRacuna,
           //     Ukupno = racun.Ukupno ,//OVDE
           };


            return dao.Insert(k);
        }

        public bool ChangeBill(RacunIM racun)
        {
            Racun d = dao.FindById(racun.IdRacuna);
            d.IdRacuna = racun.IdRacuna;


            return dao.Update(d);
        }

        public bool DeleteBill(int idracuna)
        {
            return dao.Delete(idracuna);
        }

        public List<RacunIM> GetAllBills()
        {
            List<Racun> lista = dao.GetAll();
            List<RacunIM> retVal = new List<RacunIM>();
            foreach (var item in lista)
            {
                retVal.Add(new RacunIM() { IdRacuna = item.IdRacuna });
            }
            return retVal;
        }
    }
}
