using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsExam.Classes
{
    class AngryMagic : ElfMag
    {
        public override void Operation()
        {
            base.Operation();
            base.being = "Злой Маг ";
            base.attack += 70;
            base.speed += 20;
            base.health += 0;
            base.protection += 0;

        }
    }
}
