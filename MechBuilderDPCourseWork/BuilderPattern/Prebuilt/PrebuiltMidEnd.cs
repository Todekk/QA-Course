using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCBuilder.BuilderPattern
{
    internal class PrebuiltMidEnd : PCBuilder
    {
        public PrebuiltMidEnd()
        {
            pc = new PC("Prebuilt High End Configuration");
        }
        public override void BuildClass()
        {
            pc["class"] = "Mid End Computer";

        }
        public override void BuildRAM()
        {
            pc["RAM"] = "Kingston 16GB";

        }
        public override void BuildGPU()
        {
            pc["GPU"] = "EVGA RTX 3070";

        }
        public override void BuildCPU()
        {
            pc["CPU"] = "Intel Core i7-12700K";
        }
        public override void BuildStorage()
        {
            pc["Storage"] = "Samsung 2TB";

        }
        public override void BuildMotherboard()
        {
            pc["Motherboard"] = "ASUS Prime Z690-P";
        }
        public override void TotalPrice()
        {
            string totalPrice = 2400.ToString();
            pc["totalPrice"] = totalPrice;
        }
    }
}
