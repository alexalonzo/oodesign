using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acoounts
{
    public class AccountDecorator : IAccount
    {

        private BaseAccount m_BaseAccount;

        public double Balance
        {
            get { return m_BaseAccount.Balance; }
            set
            {
                m_BaseAccount.Balance = value;

            }
        }

        public AccountDecorator(BaseAccount baseAccount)
        {
            m_BaseAccount = baseAccount;

        }

        public void addDeposit(double amount)
        {
            m_BaseAccount.addDeposit(amount);
        }

        public virtual void Draw(double amount)
        {
            m_BaseAccount.Draw(amount);
        }

    }
}
