using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCBuilder.BuilderPattern
{
    internal class PrebuiltLowEnd : PCBuilder
    {
        public PrebuiltLowEnd()
        {
            pc = new PC("Prebuilt Low End Configuration");
        }
        public override void BuildClass()
        {
            pc["class"] = "Low End Computer";

        }
        public override void BuildRAM()
        {
            pc["RAM"] = "TEAMGROUP 16GB";

        }
        public override void BuildGPU()
        {
            pc["GPU"] = "RTX 2060 Super";

        }
        public override void BuildCPU()
        {
            pc["CPU"] = "Intel Core i5-12400";
        }
        public override void BuildStorage()
        {
            pc["Storage"] = "Samsung 1TB";

        }
        public override void BuildMotherboard()
        {
            pc["Motherboard"] = "GIGABYTE B660M";
        }
        public override void TotalPrice()
        {
            string totalPrice = 1500.ToString();
            pc["totalPrice"] = totalPrice;
        }
    }
}
