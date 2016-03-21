using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class ShootingFleet
    {
       
        List<Robot> ShootingRobotFleet = new List<Robot>();
        ShootingRobot shootingRobot = new ShootingRobot();
        public void AddShootingRobot()
        {
            int userInput = 5;
            Console.WriteLine("press 1 to add a gun robot to your fleet of gun robots");
            Console.WriteLine("press 2 to remove to add a gun robot to your fleet of gun robots");
            Console.WriteLine("press 3 to print the army list of gun robots");
          
            while (userInput != 10)
            {
             userInput = Convert.ToInt32(Console.ReadLine());
          
            switch (userInput)
            {
                case 1:
                   
                    ShootingRobotFleet.Add(shootingRobot);
                    Console.WriteLine("you've added 1 gun robot to your fleet");
                    Console.ReadLine();
                    break;
                case 2:
                    ShootingRobotFleet.Remove(shootingRobot);
                    Console.WriteLine("you've removed 1 gun robot to your fleet");
                    Console.ReadLine();
                    break;
                case 3:
                    {
                        for( int i = 0;i < ShootingRobotFleet.Count; i++)
                       
                        Console.WriteLine(shootingRobot.robotName);
                        break;
                    }
                default:
                    Console.WriteLine("you've done nothing to increase/decrease the size of your fleet.");
                    Console.ReadLine();
                    break;
            }
        }
    }
}
}