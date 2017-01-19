using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo.Repository.Contract;
using Demo.Repository.Model;
using System.IO;
using Newtonsoft.Json;

namespace Demo.Repository.Repository
{
    public class FSAccountRepository : IRepository<Account>
    {

        public Account get(int id)
        {
            return FindObject(id);
        }


        private List<Account> ReadFile()
        {
            using (StreamReader r = new StreamReader("data.json"))
            {
                string json = r.ReadToEnd();
                List<Account> objects = JsonConvert.DeserializeObject<List<Account>>(json);
                return objects;
            }
        }

        private Account FindObject(int id)
        {
            List<Account> objects = ReadFile();
            Account o = objects.Find(x => x.Id == id);

            if (o != null)
                return o;
            else
                return o = new Account();

        }
    }
}