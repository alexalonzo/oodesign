using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo.Repository.Contract;
using Demo.Repository.Model;

namespace Demo.Repository.Repository
{
    public class FSPersonRepository : IRepository<Person>
    {
        public Person Create(Person person)
        {
            throw new NotImplementedException();
        }

        public Person Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Person get(int id)
        {
            throw new NotImplementedException();
        }

        public Person Update(Person person)
        {
            throw new NotImplementedException();
        }
    }
}
