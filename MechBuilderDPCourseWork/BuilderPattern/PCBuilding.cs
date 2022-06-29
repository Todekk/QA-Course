using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PCBuilder.DecoratorPattern;
using PCBuilder.IteratorPattern;

namespace PCBuilder.BuilderPattern
{
    internal class PCBuilding
    {
        public static void BuildingCustomEndPC()
        {
            PCBuilder builder;
            Director director = new Director();
            ConfigPC config = new ConfigPC("Buyer");            
            Console.WriteLine("Pick a PC Configuration");
            Console.WriteLine("High End, Mid End or Low End ");
            string userResponse = Console.ReadLine();
            switch (userResponse.ToLower())
            {
                case "high end":
                    builder = new HighEndPCBuilder();
                    director.Construct(builder);
                    builder.PC.Present();
                    builder.PC.Display();                    
                    break;
                case "low end":
                    builder = new LowEndPCBuilder();
                    director.Construct(builder);
                    builder.PC.Present();
                    builder.PC.Display();
                    break;
                case "mid end":
                    builder = new MidEndPCBuilder();
                    director.Construct(builder);
                    builder.PC.Present();
                    builder.PC.Display();
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }
        }

        public static void BuildingPreBuiltPC()
        {
            PCBuilder builder;
            Director director = new Director();
            ConfigPC config = new ConfigPC("Buyer");
            Buyer buyer = new Buyer(config);
            string buildChoice = Console.ReadLine();
            switch (buildChoice.ToLower())
            {
                case "1":
                    builder = new PrebuiltHighEnd();
                    director.Construct(builder);
                    builder.PC.Present();
                    builder.PC.Display();
                    buyer.Display();
                    break;
                case "2":
                    builder = new PrebuiltHighEnd();
                    director.Construct(builder);
                    builder.PC.Present();
                    builder.PC.Display();
                    buyer.Display();
                    break;
                case "3":
                    builder = new PrebuiltHighEnd();
                    director.Construct(builder);
                    builder.PC.Present();
                    builder.PC.Display();
                    buyer.Display();
                    break;
                default:
                    Console.WriteLine("Invalid Input!");
                    break;

            }
        }
        }
}
