using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCBuilder
{
    internal class Director
    {
        public void Construct(PCBuilder pcBuilder)
        {
            pcBuilder.BuildClass();
            pcBuilder.BuildRAM();
            pcBuilder.BuildGPU();
            pcBuilder.BuildCPU();
            pcBuilder.BuildStorage();
            pcBuilder.BuildMotherboard();
            pcBuilder.TotalPrice();
        }
        
    }
}
