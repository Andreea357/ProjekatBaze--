using Butik.IntermediaryModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class LoggedInRadnici
    {
        private static RadnikIM instance = null;

        private LoggedInRadnici()
        {
        }

        public static RadnikIM Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new RadnikIM();
                }
                return instance;
            }
            set
            {
                if (instance == null)
                {
                    instance = value;
                }
                else
                {
                    instance = null;
                }
            }
        }
    }
}
