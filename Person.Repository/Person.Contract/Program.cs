using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo.Repository.Repository;
using Demo.Repository.Model;
using Demo.Repository.Contract;
using Demo.Repository;

namespace Demo.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = getPersonInMemory();
            Console.WriteLine(p.Name);
            Account a = getAccount();
            Console.WriteLine(a.Description);
        }

        private static Person getPersonInMemory() {
            IRepository<Person> im = new IMPersonRepository();
            return im.get(2);
        }

        private static Account getAccount()
        {
            IRepository<Account> fs = new FSAccountRepository();
            return fs.get(3);
        }

    }
}
