using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsExam.Classes
{   // Лучник
    public class Archer : ManWarrior
    {
        public override void Operation()
        {
            base.Operation();
            base.being = "Лучник   ";
            base.attack += 20;
            base.speed += 20;
            base.health += 50;
            base.protection += 10;
      
        }
    }
}

