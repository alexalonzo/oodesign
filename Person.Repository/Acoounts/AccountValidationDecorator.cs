using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acoounts
{
    public class AccountValidationDecorator : AccountDecorator
    {
        private BaseAccount m_BaseAccount;
        public AccountValidationDecorator(BaseAccount baseAccount) : base(baseAccount)
        {
            this.m_BaseAccount = baseAccount;
        }

        public bool drawAllowed(double amount)
        {
            if ((m_BaseAccount.Balance - amount) < 0)
                return false;
            else
                return true;
        }

    }
}
