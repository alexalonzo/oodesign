using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo.Repository.Repository;
using Demo.Repository.Model;
using Demo.Repository.Contract;

namespace Demo.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            IRepository<Person> im = new IMPersonRepository();
            Person p = im.get(2);
            if (p != null)
            {
                Console.Write(p.Name);
            }
            else {
                Console.Write("Get method failed");
            }
            Console.WriteLine();
        }
    }
}
