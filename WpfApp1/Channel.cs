using Butik.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class Channel
    {
        public IRadnik RadnikProxy { get; set; }
        public IProdavac ProdavacProxy { get; set; }
        public IButik ButikProxy { get; set; }
        public IKasa KasaProxy { get; set; }
        public IRacun RacunProxy { get; set; }
        public IKupac KupacProxy { get; set; }
        public IKupuje KupujeProxy { get; set; }
        public IMenadzer MenadzerProxy { get; set; }
        public IProizvod ProizvodProxy { get; set; }


        private static Channel instance;

        public static Channel Instance
        {
            get
            {
                if (instance == null)
                    instance = new Channel();
                return instance;
            }
        }

        public Channel()
        {
            NetTcpBinding binding = new NetTcpBinding();
            binding.Security.Mode = SecurityMode.None;
            //binding.Security.Transport.ClientCredentialType = TcpClientCredentialType.Windows;

            binding.MaxReceivedMessageSize = 1000000;
            binding.OpenTimeout = TimeSpan.FromMinutes(2);
            binding.SendTimeout = TimeSpan.FromMinutes(2);
            binding.ReceiveTimeout = TimeSpan.FromMinutes(10);

            ChannelFactory<IRadnik> channelFactoryRadnik = new ChannelFactory<IRadnik>(binding, new EndpointAddress("net.tcp://localhost:11001/IRadnik"));
            RadnikProxy = channelFactoryRadnik.CreateChannel();

            ChannelFactory<IKupuje> channelFactoryKupuje = new ChannelFactory<IKupuje>(binding, new EndpointAddress("net.tcp://localhost:11001/IKupuje"));
            KupujeProxy = channelFactoryKupuje.CreateChannel();

            ChannelFactory<IKupac> channelFactoryKupac = new ChannelFactory<IKupac>(binding, new EndpointAddress("net.tcp://localhost:11001/IKupac"));
            KupacProxy = channelFactoryKupac.CreateChannel();

            ChannelFactory<IMenadzer> channelFactoryMenadzer = new ChannelFactory<IMenadzer>(binding, new EndpointAddress("net.tcp://localhost:11001/IMenadzer"));
            MenadzerProxy = channelFactoryMenadzer.CreateChannel();

            ChannelFactory<IButik> channelFactoryButik = new ChannelFactory<IButik>(binding, new EndpointAddress("net.tcp://localhost:11001/IButik"));
            ButikProxy = channelFactoryButik.CreateChannel();

            ChannelFactory<IKasa> channelFactoryKasa = new ChannelFactory<IKasa>(binding, new EndpointAddress("net.tcp://localhost:11001/IKasa"));
            KasaProxy = channelFactoryKasa.CreateChannel();

            ChannelFactory<IProdavac> channelFactoryProdavac = new ChannelFactory<IProdavac>(binding, new EndpointAddress("net.tcp://localhost:11001/IProdavac"));
            ProdavacProxy = channelFactoryProdavac.CreateChannel();

            ChannelFactory<IProizvod> channelFactoryProizvod = new ChannelFactory<IProizvod>(binding, new EndpointAddress("net.tcp://localhost:11001/IProizvod"));
            ProizvodProxy = channelFactoryProizvod.CreateChannel();

            ChannelFactory<IRacun> channelFactoryRacun = new ChannelFactory<IRacun>(binding, new EndpointAddress("net.tcp://localhost:11001/IRacun"));
            RacunProxy = channelFactoryRacun.CreateChannel();
        }




    }
}
