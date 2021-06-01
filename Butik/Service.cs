using Butik.Interfaces;
using Butik.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Butik
{
    public class Service
    {
        private static ServiceHost ButikServiceHost;
        private static ServiceHost KasaServiceHost;
        private static ServiceHost KupacServiceHost;
        private static ServiceHost KupujeServiceHost;
        private static ServiceHost MenadzerServiceHost;
        private static ServiceHost ProdavacServiceHost;
        private static ServiceHost ProizvodServiceHost;
        private static ServiceHost RacunServiceHost;
        private static ServiceHost RadnikServiceHost;

        public Service()
        {
            NetTcpBinding binding = new NetTcpBinding();
            binding.Security.Mode = SecurityMode.None;
            //binding.Security.Transport.ClientCredentialType = TcpClientCredentialType.Windows;

            binding.MaxReceivedMessageSize = 1000000;
            binding.OpenTimeout = TimeSpan.FromMinutes(2);
            binding.SendTimeout = TimeSpan.FromMinutes(2);
            binding.ReceiveTimeout = TimeSpan.FromMinutes(10);

            ButikServiceHost = new ServiceHost(typeof(ButikService));
            ButikServiceHost.AddServiceEndpoint(typeof(IButik), binding, new Uri("net.tcp://localhost:11001/IButik"));

            KasaServiceHost = new ServiceHost(typeof(KasaService));
            KasaServiceHost.AddServiceEndpoint(typeof(IKasa), binding, new Uri("net.tcp://localhost:11001/IKasa"));

            RacunServiceHost = new ServiceHost(typeof(RacunService));
            RacunServiceHost.AddServiceEndpoint(typeof(IRacun), binding, new Uri("net.tcp://localhost:11001/IRacun"));

            RadnikServiceHost = new ServiceHost(typeof(RadnikService));
            RadnikServiceHost.AddServiceEndpoint(typeof(IRadnik), binding, new Uri("net.tcp://localhost:11001/IRadnik"));

            ProdavacServiceHost = new ServiceHost(typeof(ProdavacService));
            ProdavacServiceHost.AddServiceEndpoint(typeof(IProdavac), binding, new Uri("net.tcp://localhost:11001/IProdavac"));

            MenadzerServiceHost = new ServiceHost(typeof(MenadzerService));
            MenadzerServiceHost.AddServiceEndpoint(typeof(IMenadzer), binding, new Uri("net.tcp://localhost:11001/IMenadzer"));

            KupujeServiceHost = new ServiceHost(typeof(KupujeService));
            KupujeServiceHost.AddServiceEndpoint(typeof(IKupuje), binding, new Uri("net.tcp://localhost:11001/IKupuje"));

            ProizvodServiceHost = new ServiceHost(typeof(ProizvodService));
            ProizvodServiceHost.AddServiceEndpoint(typeof(IProizvod), binding, new Uri("net.tcp://localhost:11001/IProizvod"));

            KupacServiceHost = new ServiceHost(typeof(KupacService));
            KupacServiceHost.AddServiceEndpoint(typeof(IKupac), binding, new Uri("net.tcp://localhost:11001/IKupac"));
        }

        public void Open()
        {
            ButikServiceHost.Open();
            KasaServiceHost.Open();
            RacunServiceHost.Open();
            RadnikServiceHost.Open();
            ProdavacServiceHost.Open();
            MenadzerServiceHost.Open();
            KupujeServiceHost.Open();
            ProizvodServiceHost.Open();
            KupacServiceHost.Open();
            Console.WriteLine("Service hosts open at: " + DateTime.Now);
        }

        public void Close()
        {
            ButikServiceHost.Close();
            KasaServiceHost.Close();
            RacunServiceHost.Close();
            RadnikServiceHost.Close();
            ProdavacServiceHost.Close();
            MenadzerServiceHost.Close();
            KupujeServiceHost.Close();
            ProizvodServiceHost.Close();
            KupacServiceHost.Close();
            Console.WriteLine("Service hosts closing at: " + DateTime.Now);
        }
    }
}
