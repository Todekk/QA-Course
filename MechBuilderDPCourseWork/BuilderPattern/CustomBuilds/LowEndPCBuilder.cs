using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace PCBuilder
{

    internal class LowEndPCBuilder : PCBuilder
    {
        int priceGpu;
        int priceCpu;
        int priceMB;
        int priceST;
        int priceRAM;
        public LowEndPCBuilder()
        {
            pc = new PC("Low End Configuration");
        }
        public override void BuildClass()
        {
            pc["class"] = "Low End Computer";
        }
        public override void BuildRAM()
        {
            Console.WriteLine("------------------------------------------");
            Console.Write("1.TEAMGROUP 16GB, 2.TEAMGROUP 8GB");
            Console.Write("\nInput: ");
            pc["RAM"] = Console.ReadLine();
            switch (pc["RAM"].ToLower())
            {

                case "1":
                    pc["RAM"] = "TEAMGROUP 16GB";
                    priceRAM = 70;
                    break;
                case "2":
                    pc["RAM"] = "TEAMGROUP 16GB";
                    priceRAM = 60;
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
            Console.Write("1. RTX 2060, 2.XFX RX 6600 XT");
            Console.Write("\nInput: ");
            pc["GPU"] = Console.ReadLine();
            switch (pc["GPU"].ToLower())
            {

                case "1":
                    pc["GPU"] = "RTX 2060";
                    priceGpu = 700;
                    break;
                case "2":
                    pc["GPU"] = "XFX RX 6600 XT";
                    priceGpu = 550;
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
            Console.Write("1.Intel Core i5-12400, 2.Intel Core i5-11400F");
            Console.Write("\nInput: ");
            pc["CPU"] = Console.ReadLine();
            switch (pc["CPU"].ToLower())
            {

                case "1":
                    pc["CPU"] = "Intel Core i5-12400";
                    priceCpu = 280;
                    break;
                case "2":
                    pc["CPU"] = "Intel Core i5-11400F";
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
            Console.Write("1. Kingston 1TB, 2.Samsung 500GB");
            Console.Write("\nInput: ");
            pc["Storage"] = Console.ReadLine();
            switch (pc["Storage"].ToLower())
            {

                case "1":
                    pc["Storage"] = "Kingston 1TB";
                    priceST = 200;
                    break;
                case "2":
                    pc["Storage"] = "Samsung 500GB";
                    priceST = 300;
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
            Console.Write("1.GIGABYTE B660M, 2.ASUS H510M");
            Console.Write("\nInput: ");
            pc["Motherboard"] = Console.ReadLine();
            switch (pc["Motherboard"].ToLower())
            {

                case "1":
                    pc["Motherboard"] = "GIGABYTE B660M";
                    priceMB = 100;
                    break;
                case "2":
                    pc["Motherboard"] = "ASUS H510M";
                    priceMB = 300;
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
