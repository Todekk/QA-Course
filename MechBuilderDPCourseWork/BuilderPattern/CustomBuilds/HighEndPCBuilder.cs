using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCBuilder
{
    internal class HighEndPCBuilder : PCBuilder
    {
        int priceGpu;
        int priceCpu;
        int priceMB;
        int priceST;
        int priceRAM;
        public HighEndPCBuilder()
        {
            pc = new PC("High End Configuration");
        }
        public override void BuildClass()
        {
            pc["class"] = "High End Computer";

        }
        public override void BuildRAM()
        {            
            Console.WriteLine("------------------------------------------");
            Console.Write("1. G.Skill Trident Z5 DDR5-6400 2x16GB,2. Kingston 16GB");
            Console.Write("\nInput: ");
            pc["RAM"] = Console.ReadLine();
            switch (pc["RAM"].ToLower())
            {

                case "1":
                    pc["RAM"] = "G.Skill Trident Z5 DDR5-6400 2x16GB";
                    priceRAM = 150;
                    break;
                case "2":
                    pc["RAM"] = "Kingston 16GB";
                    priceRAM = 140;
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
            Console.Write("1. RTX 3080 Ti,2. MSI RTX 3090");
            Console.Write("\nInput: ");
            pc["GPU"] = Console.ReadLine();
            switch (pc["GPU"].ToLower())
            {

                case "1":
                    pc["GPU"] = "RTX 3080 Ti";
                    priceGpu = 1200;
                    break;
                case "2":
                    pc["GPU"] = "MSI RTX 3080";
                    priceGpu = 1400;
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
            Console.Write("1.Intel Core i9 12900K, 2. Intel Core i7-12700K");
            Console.Write("\nInput: ");
            pc["CPU"] = Console.ReadLine();
            switch (pc["CPU"].ToLower())
            {

                case "1":
                    pc["CPU"] = "Intel Core i9 12900K";
                    priceCpu = 596;
                    break;
                case "2":
                    pc["CPU"] = "Intel Core i7-12700K";
                    priceCpu = 400;
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
            Console.Write("1. Sabrent Rocket Q 4TB, 2. Samsung 3TB");
            Console.Write("\nInput: ");
            pc["Storage"] = Console.ReadLine();
            switch (pc["Storage"].ToLower())
            {

                case "1":
                    pc["Storage"] = "Sabrent Rocket Q 4TB";
                    priceST = 600;
                    break;
                case "2":
                    pc["Storage"] = "Samsung 3TB";
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
            Console.Write("1. Gigabyte Z690 Aorus Pro, 2. ASUS Prime Z690-P");
            Console.Write("\nInput: ");
            pc["Motherboard"] = Console.ReadLine();
            switch (pc["Motherboard"].ToLower())
            {

                case "1":
                    pc["Motherboard"] = "Gigabyte Z690 Aorus Pro";
                    priceMB = 290;
                    break;
                case "2":
                    pc["Motherboard"] = "ASUS Prime Z690-P";
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
