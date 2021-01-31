using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsExam.Classes
{
    class ElfWarrior : ElfComponent
    {
        public override void Operation()
        {
            base.Operation();
            base.being = "Эльф Воин";
            base.attack += 20;
            base.speed -= 10;
            base.health += 100;
            base.protection += 20;

        }
    }
}
