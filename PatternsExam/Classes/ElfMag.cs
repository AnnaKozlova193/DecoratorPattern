using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsExam.Classes
{
    class ElfMag : ElfComponent
    {
        public override void Operation()
        {
            base.Operation();
            base.being = "Эльф Маг  ";
            base.attack += 10;
            base.speed += 10;
            base.health -= 50;
            base.protection += 10;

        }
    }
}

