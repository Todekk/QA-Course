using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCBuilder.DecoratorPattern
{
    public abstract class Decorator : Component
    {
        protected Component component;
        // Constructor
        public Decorator(Component component)
        {
            this.component = component;
        }
        public override void Display()
        {
            component.Display();
        }
    }
}
