using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cake
{
    public class CherryDecorator : Decorator
    {
        public CherryDecorator(IBakeryComponent baseComponent) : base(baseComponent)
        {
            this.m_Name = "Cherry";
            this.m_Price = 2.0;
        }
    }
}
