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
    class RacunModel : BindableBase
    {
        public Window Window { get; set; }
        public MyICommand AddRacunCommand { get; set; }
        public MyICommand DeleteRacunCommand { get; set; }

        public RacunIM NoviRacun { get; set; }
        private int IdRacuna { get; set; }
        private string Ukupno { get; set; }
    }
}
