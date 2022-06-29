using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCBuilder.DecoratorPattern
{
    public abstract class Component
    {
        private string priceToPay;
        public string PriceToPay
        {
            get { return priceToPay; }
            set { priceToPay = value; }
        }
        public abstract void Display();
    }
}
