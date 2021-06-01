using Butik.Helpers;
using Butik.IntermediaryModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace WpfApp1.ViewModel
{
    public class ButikModel : BindableBase
    {
        public Window Window { get; set; }
        bool Izmena = false;
        public ICommand AddButikCommand { get; set; }
        public MyICommand DeleteButikCommand { get; set; }
        ButikIM SelectedButik { get; set; }
        string pocetak;
        public string Naziv
        {
            get
            {
                return Naziv;
            }
            set
            {
                Naziv = value;
                OnPropertyChanged("Naziv");
            }
        }

        string Adresa;
        public string adresa
        {
            get
            {
                return Adresa;
            }
            set
            {
                Adresa = value;
                OnPropertyChanged("Adresa");
            }
        }
     
    }
}
