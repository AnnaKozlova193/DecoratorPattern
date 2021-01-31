using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsExam.Classes
{
    class GoodMagician : ElfMag
    {
        public override void Operation()
        {
            base.Operation();
            base.being = "Добрый Маг";
            base.attack += 50;
            base.speed += 30;
            base.health += 100;
            base.protection += 30;

        }
    }
}
