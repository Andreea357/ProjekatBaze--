using Butik.Helpers;
using Butik.IntermediaryModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApp1.ViewModel
{
   public class KasaModel : BindableBase
    {
        public Window Window { get; set; }
        public MyICommand AddKasaCommand { get; set; }
        public MyICommand DeleteKasaCommand { get; set; }

        public KasaIM Novakasa { get; set; }
        bool changing = false;

        private int idkase { get; set; }
    }
}
