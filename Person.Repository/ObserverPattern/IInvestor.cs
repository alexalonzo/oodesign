using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    /// <summary>
    /// The 'Observer'
    /// </summary>
    public interface IInvestor
    {
        void Update(Stock stock);
    }
}
