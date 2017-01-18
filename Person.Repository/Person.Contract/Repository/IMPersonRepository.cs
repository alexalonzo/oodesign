using System;
using Demo.Repository.Model;
using Demo.Repository.Contract;
using System.Collections.Generic;

namespace Demo.Repository.Repository
{
    public class IMPersonRepository : IRepository<Person>
    {
        private List<Person> People = new List<Person>();

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
            Person p = this.People.Find(x => x.Id == id);
            return p;
        }

        public Person Update(Person person)
        {
            throw new NotImplementedException();
        }

        public IMPersonRepository() {
            this.People = new List<Person>() {
                new Person {Id=1, Name="Person1", DOB=DateTime.Parse("03/03/1978")},
                new Person {Id=2, Name="Person2", DOB=DateTime.Parse("02/02/1978") },
                new Person {Id=3, Name="Person3", DOB=DateTime.Parse("01/01/1978")  } };

        }

    }
}
