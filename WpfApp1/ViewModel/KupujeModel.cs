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
    public class KupujeModel : BindableBase
    {
        public Window Window { get; set; }
        public MyICommand AddKupujeCommand { get; set; }
        public MyICommand DeleteKupujeCommand { get; set; }

        public KupujeIM NoviKupuje { get; set; }
    }
}
