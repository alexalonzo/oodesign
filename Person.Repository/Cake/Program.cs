using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            CakeBase cBase = new CakeBase();
            Console.WriteLine(string.Format("Item: {0} , Price: {1} ", cBase.GetName(), cBase.GetPrice().ToString()));

            CreamDecorator creamCake = new CreamDecorator(cBase);
            Console.WriteLine(string.Format("Item: {0} , Price: {1} ", creamCake.GetName(), creamCake.GetPrice().ToString()));
        }
    }
}
