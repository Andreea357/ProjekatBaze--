using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Butik
{
    class Program
    {
        static void Main(string[] args)
        {
            Service service = new Service();
            service.Open();
            Console.ReadLine();
            service.Close();
        }
    }
}
