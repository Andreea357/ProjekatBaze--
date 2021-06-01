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
    class KupacModel : BindableBase
    {
        public Window Window { get; set; }
        public MyICommand AddKupacCommand { get; set; }
        public MyICommand DeleteKupacCommand { get; set; }

        public KupacIM NovaKupac { get; set; }
        bool changing = false;

        private int IdKupca { get; set; }
    
    }
}
