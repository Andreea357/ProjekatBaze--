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
    class MenadzerService : IMenadzer
    {
        private static MenadzerDA dao = new MenadzerDA();
        public bool Addmanager(MenadzerIM menadzer)
        {
            Menadzer k = new Menadzer()
            {
                JMBGMenadzera = menadzer.JMBGMenadzera.ToString(),
                
            };


            return dao.Insert(k);
        }

        public bool Changemanager(MenadzerIM menadzer)
        {
            Menadzer d = dao.FindById(menadzer.JMBGMenadzera);
            d.JMBGMenadzera = menadzer.JMBGMenadzera.ToString();


            return dao.Update(d);
        }

        public bool Deletemanager(int menadzer)
        {
            return dao.Delete(menadzer);
        }

        public List<MenadzerIM> GetAllmanagers()
        {
            List<Menadzer> lista = dao.GetAll();
            List<MenadzerIM> retVal = new List<MenadzerIM>();
            foreach (var item in lista)
            {//ovde
                //retVal.Add(new MenadzerIM() { JMBGMenadzera = item.JMBGMenadzera.ToString()});
            }
            return retVal;
        }
    }
}
