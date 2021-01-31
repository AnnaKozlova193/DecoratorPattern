using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsExam.Classes
{  // Арбалетчик
    class Abalester : ElfWarrior
    {
        public override void Operation()
        {
            base.Operation();
            base.being = "Арбалетчик";
            base.attack += 20;
            base.speed += 10;
            base.health += 50;
            base.protection -= 10;

        }
    }
}
