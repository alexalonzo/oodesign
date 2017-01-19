using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acoounts
{
    public class BaseAccount :IAccount
    {
        public int Id { get; set; }
        public string AccountNumber { get; set; }
        public double Balance { get; set; }

        public void Draw(double amount)
        {
            this.Balance -= amount;
        }

        public void addDeposit(double amount)
        {
            this.Balance += amount;
        }
    }
}
