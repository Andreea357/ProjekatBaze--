using Butik.Helpers;
using Butik.IntermediaryModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WpfApp1.Views;

namespace WpfApp1.ViewModel
{
    public class MainViewModel : BindableBase
    {
        public MyICommand AddRadniciCommand { get; set; }
        public MyICommand ChangeInfoCommand { get; set; }
        public MyICommand DeleteRadniciCommand { get; set; }

         public MyICommand AddProizvodCommand { get; set; }
        public MyICommand ChangeProizvodCommand { get; set; }
        public MyICommand DeleteProizvodCommand { get; set; }

           public MyICommand AddKasaCommand { get; set; }
        public MyICommand ChangeKasaCommand { get; set; }
        public MyICommand DeleteKasaCommand { get; set; }

           public MyICommand AddKupacCommand { get; set; }
        public MyICommand ChangeKupacCommand { get; set; }
        public MyICommand DeleteKupacCommand { get; set; }

        public MyICommand AddRacunCommand { get; set; }
        public MyICommand ChangeRacunCommand { get; set; }
        public MyICommand DeleteRacunCommand { get; set; }


        List<RadnikIM> radnici { get; set; }
        public List<RadnikIM> Radnici
        {
            get
            {
                return radnici;
            }
            set
            {
                radnici = value;
                OnPropertyChanged("Radnici");
            }
        }

        List<KupacIM> kupci { get; set; }
        public List<KupacIM> Kupci
        {
            get
            {
                return kupci;
            }
            set
            {
                kupci = value;
                OnPropertyChanged("Kupci");
            }
        }

          List<ButikIM> butici { get; set; }
     /*   public List<ButikIM> Butici
        {
            get
            {
                return butici;
            }
            set
            {
                butici = value;
                OnPropertyChanged("Butici");
            }
        }*/

           List<ProizvodIM> proizvodi { get; set; }
        public List<ProizvodIM> Proizvodi
        {
            get
            {
                return proizvodi;
            }
            set
            {
                proizvodi = value;
                OnPropertyChanged("Proizvodi");
            }
        }

           List<RacunIM> racunIMs { get; set; }
        

        
            

        public RadnikIM loggedIn { get; set; }
        public RadnikIM LoggedIn
        {
            get
            {
                return loggedIn;
            }
            set
            {
                loggedIn = value;
                OnPropertyChanged("LoggedIn");
            }
        }
        Boolean admin;
        public Boolean Admin
        {
            get
            {
                return admin;
            }
            set
            {
                admin = value;
                OnPropertyChanged("Admin");
            }
        }
        public string IsAdmin { get; set; }
        public string AuthorizeAdmin { get; set; }
        public string AuthorizeZaposleni { get; set; }
        public MyICommand AddUserCommand { get; set; }
        public RadnikIM SelectedRadnici { get; set; }
        public void OnDeleteRadnici()
        {
            if (SelectedRadnici != null)
            {
                if (Channel.Instance.RadnikProxy.DeleteWorker(SelectedRadnici.JMBG))
                {
                    OnChange();
                }
            }
            else
            {
                MessageBox.Show("Molimo selektujte Zaposlenog prvo.", "Greška!", MessageBoxButton.OK);
            }
        }

        public void OnChangeRadnici()
        {
         /*   Butik = Channel.Instance.ButikProxy.ge(LoggedIn.Id_zaposlenog);
            Predavanja = Channel.Instance.PredavanjaProxy.GetPredavanjaForZaposleni(LoggedIn);
            Casovi = Channel.Instance.CasovyProxy.GetCasoviForZaposleni(LoggedIn.Id_zaposlenog);
            KontrolneTacke = Channel.Instance.KTProxy.GetKTForZaposleni(LoggedIn.Id_zaposlenog);
            Odeljenja = Channel.Instance.OdeljenjaProxy.GetOdeljenjaForZaposleni(LoggedIn.Id_zaposlenog);
       */ }
        public void OnAddZaposleni()
        {
            new AddRadnikView(false).ShowDialog();
            OnChange();
        }
        public MainViewModel()
        {
            LoggedIn = LoggedInRadnici.Instance;
            if (LoggedInRadnici.Instance.ImeRadnika != "admin")
            {
                Admin = false;
                IsAdmin = "Visible";
                AuthorizeAdmin = "Hidden";
                AuthorizeZaposleni = "Visible";
                //        OnZhangeZaposleni();
            }
            else
            {
                Admin = true;
                IsAdmin = "Hidden";
                AuthorizeAdmin = "Visible";
                AuthorizeZaposleni = "Hidden";
                //  OnChange();
            }
            AddRadniciCommand = new MyICommand(OnAddRadnici);

        }

      
       
        public void OnChange()
        {
            try
            {
                LoggedIn = LoggedInRadnici.Instance;
                radnici = Channel.Instance.RadnikProxy.GetAllWorkers();
                kupci = Channel.Instance.KupacProxy.GetAllCustomers();
                //   Odeljenja = Channel.Instance.OdeljenjaProxy.GetOdeljenja();
                //       Predmeti = Channel.Instance.PredmetiProxy.GetPredmeti();

            }
            catch (Exception e)
            {
                Console.WriteLine("Message: " + e.Message + "\n\nTrace:\n" + e.StackTrace + "\n\nInner:\n\n" + e.InnerException);
            }

        }
     //   AddRadniciCommand = new MyICommand(OnAddRadnici);

        public void OnAddRadnici()
        {
            new AddRadnikView(false).ShowDialog();
            OnChange();
        }

        public void OnChangeZaposleni()
        {
            new AddRadnikView(true).ShowDialog();
            OnChange();
        }

    }
}
