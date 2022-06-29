using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCBuilder.DecoratorPattern
{
    public class Buyer : Decorator
    {
        protected readonly List<string> buyers = new List<string>();
        // Constructor
        public Buyer(Component component)
            : base(component)
        {
        }
        public void BuyItem(string name)
        {
            buyers.Add(name);
            PriceToPay = PriceToPay;
        }
        public void ReturnItem(string name)
        {
            buyers.Remove(name);
            PriceToPay = PriceToPay;
        }

        public override void Display()
        {

            foreach (string buyer in buyers)
            {
                Console.WriteLine("-Buyer: " + buyer);
            }
        }
    }
}
