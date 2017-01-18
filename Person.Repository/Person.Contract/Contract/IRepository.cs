using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo.Repository.Model;

namespace Demo.Repository.Contract
{
    public interface IRepository<T>
    {
        T get(int id);
        T Create(T model);
        T Update(T model);
        T Delete(int id);
    }
}
