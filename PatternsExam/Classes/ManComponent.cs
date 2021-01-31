using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsExam.Classes
{
    public class ManComponent : Component
    {
        public override void Operation()
        {
            being = "Человек:  ";
            attack = 20;
            speed = 20;
            health = 150;
            protection = 0;
        }
    }
}

