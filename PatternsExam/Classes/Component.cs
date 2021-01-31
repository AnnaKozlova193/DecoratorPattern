using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsExam.Classes
{
 
    public abstract class Component
    {
        public string being { get; protected set; }
        public int attack { get; protected set; }
        public int speed { get; protected set; }
        public int health { get; protected set; }
        public int protection { get; protected set; }

        public abstract void Operation();
    }
}
