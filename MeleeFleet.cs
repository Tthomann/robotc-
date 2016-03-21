using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class MeleeFleet
    {
     
       public MeleeRobot meleeRobot = new MeleeRobot();
      


        public List<Robot> MeleeRobotFleet = new List<Robot>();
        public void AddMeleeRobot()
        {

            int userInput = 5;
            Console.WriteLine("press 1 to add a sword robot to your fleet of sword robots");
            Console.WriteLine("press 2 to remove to add a sword robot to your fleet of sword robots");
            Console.WriteLine("press 3 to print the army list of sword robots");
           
            while (userInput > 0)
            {
               userInput = Convert.ToInt32(Console.ReadLine());
                switch (userInput)
                {
        
                    case 1:
                        Console.WriteLine("you've added 1 sword robot to your fleet");
                        MeleeRobotFleet.Add(new MeleeRobot());
                  
                        Console.ReadLine();
                        break;
                    case 2:
                        MeleeRobotFleet.Remove(meleeRobot);
                        Console.WriteLine("you've removed 1 sword robot to your fleet");
                       
                        Console.ReadLine();
                        break;
                    case 3:

                        {
                        foreach (Robot unit in MeleeRobotFleet)
                        Console.WriteLine(unit.robotName);                     
                        break;
                    }
                    default:
                        Environment.Exit(0);
                        break;

                }
             
            }
         
        }
    }
}
