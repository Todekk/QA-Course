using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCBuilder
{

    internal class MidEndPCBuilder : PCBuilder
    {
        int priceGpu;
        int priceCpu;
        int priceMB;
        int priceST;
        int priceRAM;
        public MidEndPCBuilder()
        {
            pc = new PC("Mid End Configuration");
        }
        public override void BuildClass()
        {
            pc["class"] = "Mid end Computer";
        }
        public override void BuildRAM()
        {
            Console.WriteLine("------------------------------------------");
            Console.Write("1.Kingston 16GB, 2.XPG Hunter 16GB");
            Console.Write("\nInput: ");
            pc["RAM"] = Console.ReadLine();
            switch (pc["RAM"].ToLower())
            {

                case "1":
                    pc["RAM"] = "Kingston 16GB";
                    priceRAM = 100;
                    break;
                case "2":
                    pc["RAM"] = "XPG Hunter 16GB";
                    priceRAM = 90;
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    Environment.Exit(0);
                    break;
            }
        }
        public override void BuildGPU()
        {

            Console.WriteLine("------------------------------------------");
            Console.Write("1.EVGA RTX 3070, 2.EVGA RTX 3060 Ti");
            Console.Write("\nInput: ");
            pc["GPU"] = Console.ReadLine();
            switch (pc["GPU"].ToLower())
            {

                case "1":
                    pc["GPU"] = "EVGA RTX 3070";
                    priceGpu = 900;
                    break;
                case "2":
                    pc["GPU"] = "EVGA RTX 3060 Ti";
                    priceGpu = 840;
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    Environment.Exit(0);
                    break;
            }
        }
        public override void BuildCPU()
        {

            Console.WriteLine("------------------------------------------");
            Console.Write("1.Intel Core i7-12700K, 2.Intel Core i5-12600K");
            Console.Write("\nInput: ");
            pc["CPU"] = Console.ReadLine();
            switch (pc["CPU"].ToLower())
            {

                case "1":
                    pc["CPU"] = "Intel Core i7-12700K";
                    priceCpu = 400;
                    break;
                case "2":
                    pc["CPU"] = "Intel Core i5-12600K";
                    priceCpu = 300;
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    Environment.Exit(0);
                    break;
            }
        }
        public override void BuildStorage()
        {

            Console.WriteLine("------------------------------------------");
            Console.Write("1.Samsung 1TB, 2.Samsung 2TB");
            Console.Write("\nInput: ");
            pc["Storage"] = Console.ReadLine();
            switch (pc["Storage"].ToLower())
            {

                case "1":
                    pc["Storage"] = "Samsung 1TB";
                    priceST = 300;
                    break;
                case "2":
                    pc["Storage"] = "Samsung 2TB";
                    priceST = 500;
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    Environment.Exit(0);
                    break;
            }
        }
        public override void BuildMotherboard()
        {
            Console.WriteLine("------------------------------------------");
            Console.Write("1. ASUS Prime Z690-P, 2.GIGABYTE B660M");
            Console.Write("\nInput: ");
            pc["Motherboard"] = Console.ReadLine();
            switch (pc["Motherboard"].ToLower())
            {

                case "1":
                    pc["Motherboard"] = "ASUS Prime Z690-P";
                    priceMB = 300;
                    break;
                case "2":
                    pc["Motherboard"] = "GIGABYTE B660M";
                    priceMB = 270;
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    Environment.Exit(0);
                    break;
            }
        }
        public override void TotalPrice()
        {
            string totalPrice = (priceGpu + priceCpu + priceMB + priceST + priceRAM).ToString();
            pc["totalPrice"] = totalPrice;
        }
    }
}
