using Butik.Interfaces;
using Butik.IntermediaryModels;
using ProjekatBaze;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjekatBaze.Data;

namespace Butik.Services
{
    class ButikService : IButik
    {
        private static ButikDA dao = new ButikDA();
        public bool AddBoutique(ButikIM butik)
        {
            /*Butik k = new Butik()
            {
                IdKase = butik.id,
            };


            return dao.Insert(k);*/
            throw new NotImplementedException();
        }

        public bool ChangeBoutiques(ButikIM butik)
        {
            throw new NotImplementedException();
        }

        public bool DeleteBoutique(int idButika)
        {
            throw new NotImplementedException();
        }

        public List<ProizvodIM> GetAllBoutique()
        {
            throw new NotImplementedException();
        }
    }
}
