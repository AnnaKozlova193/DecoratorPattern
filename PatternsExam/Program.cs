using PatternsExam.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsExam
{
    class Program
    {
        static void Main(string[] args)
        {
            ManComponent manComponent = new ManComponent();
            ManWarrior manWarrior = new ManWarrior();
            SwordWearing swordWearing = new SwordWearing();
            Rider rider = new Rider();
            Archer archer = new Archer();
            manComponent.Operation();
            manWarrior.Operation();
            swordWearing.Operation();
            archer.Operation();
            rider.Operation();

            ElfComponent elf = new ElfComponent();
            ElfWarrior elfWarrior = new ElfWarrior();
            ElfMag elfMag = new ElfMag();
            Abalester abalester = new Abalester();
            GoodMagician goodMagician = new GoodMagician();
            AngryMagic angryMagic = new AngryMagic();
            elf.Operation();
            elfWarrior.Operation();
            elfMag.Operation();
            abalester.Operation();
            goodMagician.Operation();
            angryMagic.Operation();
               
            Console.WriteLine("Профессия   | Атака | Скорость | Здоровье | Защита |");
            Console.WriteLine("___________________________________________________|");
            //                        MAN
            Console.WriteLine($"{manComponent.being}  | {manComponent.attack}    | {manComponent.speed}       | {manComponent.health}      | {manComponent.protection}      |");
            Console.WriteLine($"{manWarrior.being}   | {manWarrior.attack}    | {manWarrior.speed}       | {manWarrior.health}      | {manWarrior.protection}     |");
            Console.WriteLine($"{swordWearing.being}   | {swordWearing.attack}    | {swordWearing.speed}       | {swordWearing.health}      | {swordWearing.protection}     |");
            Console.WriteLine($"{archer.being}   | {archer.attack}    | {archer.speed}       | {archer.health}      | {archer.protection}     |");
            Console.WriteLine($"{rider.being}   | {rider.attack}    | {rider.speed}       | {rider.health}      | {rider.protection}    |");
            //                        ELF
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{elf.being}   | {elf.attack}    | {elf.speed}       | {elf.health}      | {elf.protection}      |");
            Console.WriteLine($"{elfWarrior.being}   | {elfWarrior.attack}    | {elfWarrior.speed}       | {elfWarrior.health}      | {elfWarrior.protection}     |");
            Console.WriteLine($"{elfMag.being}  | {elfMag.attack}    | {elfMag.speed}       | {elfMag.health}       | {elfMag.protection}     |");
            Console.WriteLine($"{abalester.being}  | {abalester.attack}    | {abalester.speed}       | {abalester.health}      | {abalester.protection}     |");
            Console.WriteLine($"{goodMagician.being}  | {goodMagician.attack}    | {goodMagician.speed}       | {goodMagician.health}      | {goodMagician.protection}     |");
            Console.WriteLine($"{angryMagic.being}   | {angryMagic.attack}    | {angryMagic.speed}       | {angryMagic.health}       | {angryMagic.protection}     |");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("___________________________________________________|");
            Console.Read();
        }
    }
}
