using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Butik.Helpers;
using Butik.IntermediaryModels;
using System.Windows;

namespace WpfApp1.ViewModel
{
    class ProizvodModel : BindableBase
    {
        public Window Window { get; set; }
        public MyICommand AddProizvodCommand { get; set; }
        public MyICommand DeleteProizvodCommand { get; set; }

        public ProizvodIM NoviProizvod { get; set; }

        private int KodProizvoda { get; set; }
        private int Cijena { get; set; }
        private string NazivProizvoda { get; set; }

    }
}
