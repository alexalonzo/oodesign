using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cake
{
    public abstract class Decorator : IBakeryComponent
    {
        IBakeryComponent m_BaseComponent = null;
        protected string m_Name = "Undefined Decorator";
        protected double m_Price = 0.0;

        protected Decorator(IBakeryComponent baseComponent)
        {
            m_BaseComponent = baseComponent;
        }

        public string GetName()
        {
            return string.Format("{0}, {1}", m_BaseComponent.GetName(), m_Name);
        }

        public double GetPrice()
        {
            return m_Price + m_BaseComponent.GetPrice();
        }
    }
}
