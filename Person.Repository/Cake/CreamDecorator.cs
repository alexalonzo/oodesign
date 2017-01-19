using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cake
{
    public class CreamDecorator : Decorator
    {
        public CreamDecorator(IBakeryComponent baseComponent) : base(baseComponent)
        {
            this.m_Name = "Cream Decorator";
            this.m_Price = 1.0;
        }
    }
}
