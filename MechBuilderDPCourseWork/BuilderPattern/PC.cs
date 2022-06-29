using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PCBuilder.DecoratorPattern;

namespace PCBuilder
{
    internal class PC : Component
    {
        private string _pcType;
        private Dictionary<string, string> _parts = 
            new Dictionary<string, string>();
        public PC(string pcType)
        {
            _pcType = pcType;
        }
        public string this[string key]
        {
            get { return _parts[key]; }
            set { _parts[key] = value;}
        }
        public void Present()
        {
            Console.WriteLine("=========================================================================");
            Console.WriteLine("Build: {0}", _pcType);            
            Console.WriteLine("Class: {0}", _parts["class"]);
            Console.WriteLine("RAM: {0}", _parts["RAM"]);
            Console.WriteLine("GPU: {0}", _parts["GPU"]);
            Console.WriteLine("CPU: {0}", _parts["CPU"]);
            Console.WriteLine("Storage: {0}", _parts["Storage"]);
            Console.WriteLine("Motherboard: {0}", _parts["Motherboard"]);
            Console.WriteLine("=========================================================================");
        }
        public override void Display()
        {
            PriceToPay = _parts["totalPrice"];
            Console.WriteLine("TotalPrice: {0}", PriceToPay + " lv.");
        }

    }
}
