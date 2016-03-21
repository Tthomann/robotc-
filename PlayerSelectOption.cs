using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class PlayerSelectOption : Robot
    {
        Battle optionBattle = new Battle();
        MeleeFleet Mfleet = new MeleeFleet();
        ShootingFleet Sfleet = new ShootingFleet();
        MeleeRobot meleeRobot = new MeleeRobot();
        bool stop;
        public  PlayerSelectOption()
        {

        }
        public void OptionSelect()
        {
            int userInput = 5;
            Console.WriteLine("press 1 to initiate a battle between a SWORD robot and a MONSTER robot.");
            Console.WriteLine("press 2 to initiate a battle betweent a GUN robot and a MONSTER robot");
            Console.WriteLine("press 3 to modify the list of Sword Fleet");
            Console.WriteLine("press 4 to modify the list of Gun Fleet");
            Console.WriteLine("press anything else to exit program");



            while (userInput > 0) {
                userInput = Convert.ToInt32(Console.ReadLine());
                switch (userInput)
                {
                    case 1:
                        optionBattle.SvMInstance();
                       
                        
                        break;
                    case 2:
                        optionBattle.GvMInstance();
                      

                        break;
                    case 3:
                        Mfleet.AddMeleeRobot();
                   
                        break;
                    case 4:
                        Sfleet.AddShootingRobot();
                        break;
                    default:
                        Environment.Exit(0);
                        break;
                }
              
            }

        }
    }
}
