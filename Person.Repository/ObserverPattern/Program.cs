using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Stock ibm = new Stock("IBM", 120);
            ibm.Attach(new Investor("Sorros"));
            ibm.Attach(new Investor("Bekshire"));

            ibm.Price = 120.10;
            ibm.Price = 121;

            Console.ReadKey();
        }
    }
}
