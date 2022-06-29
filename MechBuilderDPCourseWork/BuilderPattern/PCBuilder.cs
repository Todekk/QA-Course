using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCBuilder
{
    internal abstract class PCBuilder
    {
        protected PC pc;
        public PC PC
        {
            get { return pc; }
        }
        public abstract void BuildRAM();
        public abstract void BuildClass();
        public abstract void BuildGPU();
        public abstract void BuildCPU();
        public abstract void BuildStorage();        
        public abstract void BuildMotherboard();
        public abstract void TotalPrice();


    }
}
