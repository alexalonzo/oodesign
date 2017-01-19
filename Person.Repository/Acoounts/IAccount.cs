using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acoounts
{
public interface IAccount
    {
        void Draw(double amount);
        void addDeposit(double amount);
    }
}
