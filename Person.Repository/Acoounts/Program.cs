using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acoounts
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseAccount a = new BaseAccount();
            a.Balance = 100;
            Console.WriteLine(a.Balance.ToString());
            a.addDeposit(500);
            Console.WriteLine(a.Balance.ToString());

            AccountDecorator AccountDec = new AccountDecorator(a);

            AccountValidationDecorator V = new AccountValidationDecorator(a);

            if (V.drawAllowed(100))
            { V.Draw(100);
                Console.WriteLine(string.Format("Draw allowed. Final Balance: {0}", V.Balance));
            }
            else
            { Console.WriteLine("Insufficient Funds"); }


        }
    }
}
