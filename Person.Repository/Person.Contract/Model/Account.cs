using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Repository.Model
{
   public class Account
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public Double TotalAmount { get; set; }
        public Double draw { get; set; }
    }
}
