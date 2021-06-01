using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Butik.Helpers;
using Butik.IntermediaryModels;
using System.Windows;
using System.Threading.Tasks;

namespace WpfApp1.ViewModel
{
    class RadnikModel : BindableBase
    {
        public RadnikModel(bool isChange)
        {
            this.isChange = isChange;
        }

        public Window Window { get; set; }
        public MyICommand AddRadnikCommand { get; set; }
        public MyICommand DeleteRadnikCommand { get; set; }

        public RadnikIM NoviRadnik { get; set; }
        private int JMBG { get; set; }
        private string ImeRadnika { get; set; }
        private string PrezimeRadnika { get; set; }
        private bool isChange { get; set; }
        public string ImeRadnika2
        {
            get { return ImeRadnika2; }
            set
            {
                ImeRadnika2 = value;
                OnPropertyChanged("ImeRadnika2");
            }
        } public string PrezimeRadnika2
        {
            get { return PrezimeRadnika2; }
            set
            {
                PrezimeRadnika2 = value;
                OnPropertyChanged("PrezimeRadnika2");
            }
        } 
        public bool IsChange
        {
            get { return isChange; }
            set
            {
                isChange = value;
                OnPropertyChanged("IsChange");
            }
        }
    }
}
