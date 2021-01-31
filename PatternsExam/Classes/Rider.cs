using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsExam.Classes
{   //Всадник
    public class Rider : SwordWearing
    {
        public override void Operation()
        {
            base.Operation();
            base.being = "Всадник  ";
            base.attack -= 10;
            base.speed += 40;
            base.health += 200;
            base.protection += 100;

        }
    }
}
