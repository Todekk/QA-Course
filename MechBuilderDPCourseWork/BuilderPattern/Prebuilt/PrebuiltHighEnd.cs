using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCBuilder.BuilderPattern
{
    internal class PrebuiltHighEnd : PCBuilder
    {
        public PrebuiltHighEnd()
        {
            pc = new PC("Prebuilt High End Configuration");
        }
        public override void BuildClass()
        {
            pc["class"] = "High End Computer";

        }
        public override void BuildRAM()
        {
            pc["RAM"] = "G.Skill Trident Z5 DDR5-6400";
           
        }
        public override void BuildGPU()
        {
            pc["GPU"] = "Nvidia GeForce RTX 3090";
            
        }
        public override void BuildCPU()
        {
            pc["CPU"] = "Intel Core i9 12900K";            
        }
        public override void BuildStorage()
        {
            pc["Storage"] = "Sabrent Rocket Q 4TB";
            
        }
        public override void BuildMotherboard()
        {
            pc["Motherboard"] = "Gigabyte Z690 Aorus Pro";            
        }
        public override void TotalPrice()
        {
            string totalPrice = 3500.ToString();
            pc["totalPrice"] = totalPrice;
        }
    }
}
