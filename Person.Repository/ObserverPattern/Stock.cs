using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class Stock : IStock
    {

        public void Attach(IInvestor investor)
        {
            _investors.Add(investor);
        }

        public void Detatch(IInvestor investor)
        {
            _investors.Remove(investor);
        }

        public void Notify()
        {
            foreach(IInvestor investor in _investors)
            {
                investor.Update(this);
            }
            Console.WriteLine("");
        }



        private string _symbol;
        private double _price;
        private List<IInvestor> _investors = new List<IInvestor>();

        public double Price
        {
            get
            {
                return _price;
            }
            set
            {
                if (_price != value)
                {
                    _price = value;
                    Notify();
                }
            }
        }

        public string Symbol
        {
            get { return _symbol; }
        }
        public Stock(string symbol, double price) {
            _symbol = symbol;
            _price = price;
        }


    }
}
