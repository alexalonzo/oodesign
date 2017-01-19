using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    /// <summary>
    /// The 'Subject'
    /// </summary>
    public  interface IStock
    {
        void Attach(IInvestor investor);
        void Detatch(IInvestor investor);
        void Notify();
    }
}
