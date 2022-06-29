using PCBuilder.DecoratorPattern;
using PCBuilder.IteratorPattern;
using PCBuilder.BuilderPattern;
namespace PCBuilder
{
    class Program
    {
        static void Main()
        {
            PCBuilder builder;
            Director director = new Director();
            ConfigPC config = new ConfigPC("Buyer");
            Buyer buyer = new Buyer(config);

            Console.Write("ENTER USERNAME: ");
            buyer.BuyItem(Console.ReadLine());

            Console.WriteLine("CUSTOM or PREBUILT PC");
            string userResponse = Console.ReadLine();

            switch(userResponse.ToLower())
            {
                case "custom":
                    PCBuilding.BuildingCustomEndPC();
                    buyer.Display();
                    break;
                case "prebuilt":
                    ConcreteAggregate a = new ConcreteAggregate();
                    a[0] = "1. High End Configuration: 3500 lv.";
                    a[1] = "2. Mid End Configuration: 2400 lv.";
                    a[2] = "3. Low End Configuration: 1500 lv.";                    
                    Iterator i = a.CreateIterator();
                    Console.WriteLine("Iterating over collection:");
                    object item = i.First();
                    while (item != null)
                    {
                        Console.WriteLine(item);
                        item = i.Next();
                    }
                    PCBuilding.BuildingPreBuiltPC();
                    buyer.Display();
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }

           
        }
    }
}
