using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsExam.Classes
{
    abstract class Decorator :Component
    {
        protected Component component;

        public Decorator (Component component)
        {
           this.component = component;
        }

        public void SetComponent(Component component)
        {
            this.component = component;
        }

        public override void Operation()
        {
            if (component != null)
            {
                component.Operation();
            }
        }

    }
}
