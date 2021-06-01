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
    public class MenadzerModel : BindableBase
    {
        public Window Window { get; set; }
        public MyICommand AddMenadzerCommand { get; set; }
        public MyICommand DeleteMenadzerCommand { get; set; }

        public MenadzerIM NoviMenadzer { get; set; }
    }
}
