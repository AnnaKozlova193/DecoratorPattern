using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsExam.Classes
{
    public class ManWarrior : ManComponent
    {
        public override void Operation()
        {
            base.Operation();
            base.being = "Воин     ";
            base.attack += 20;
            base.speed += 10;
            base.health += 50;
            base.protection += 20;
  
        }
    }
}
