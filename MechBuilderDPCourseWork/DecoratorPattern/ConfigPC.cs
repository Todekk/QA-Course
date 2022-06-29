using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCBuilder.DecoratorPattern
{
    public class ConfigPC : Component
    {
        // Constructor
        public ConfigPC(string price)
        {

            this.PriceToPay = price;
        }
        public override void Display()
        {
            Console.WriteLine(" Total Price: {0}", PriceToPay);
        }
    }
}
