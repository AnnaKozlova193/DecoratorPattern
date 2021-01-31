using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsExam.Classes
{
    public class ElfComponent : Component
    {
        public override void Operation()
        {
            being = "Эльф:    ";
            attack = 15;
            speed = 30;
            health = 100;
            protection = 0;
          
        }
    }
}
