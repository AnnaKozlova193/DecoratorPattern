using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsExam.Classes
{  // Меченосец
    public class SwordWearing : ManWarrior
    {
        public override void Operation()
        {
            base.Operation();
            base.being = "Меченосец";
            base.attack += 40;
            base.speed -= 10;
            base.health += 50;
            base.protection += 40;
      
        }
    }
}


