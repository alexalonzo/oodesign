using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class Investor : IInvestor
    {
        public void Update(Stock stock)
        {
            Console.WriteLine("Notified {0} of {1}'s " +
         "change to {2:C}", _name, stock.Symbol, stock.Price);
        }

        private string _name;

        public Investor(string name) {
            _name = name;
        }


    }
}
