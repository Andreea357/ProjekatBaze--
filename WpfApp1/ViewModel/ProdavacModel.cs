using Butik.Helpers;
using Butik.IntermediaryModels;
using System.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WpfApp1.ViewModel
{
    public class ProdavacModel : BindableBase
    {
        public Window Window { get; set; }
        public MyICommand AddProdavacCommand { get; set; }
        public MyICommand DeleteProdavacCommand { get; set; }

        public ProdavacIM NoviProdavac { get; set; }
        
           
        private string JMBGProdavca { get; set; }
        public string JMBGprodavca
        {
            get { return JMBGprodavca; }
            set
            {
                JMBGProdavca = value;
                OnPropertyChanged("JMBGprodavca");
            }
        }
    }
}
