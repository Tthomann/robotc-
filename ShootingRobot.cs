using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class ShootingRobot : Robot
    {
        public int KamikazeModifier;
        public ShootingRobot()
        {
            robotName = "Gun Robot";
            KamikazeModifier = 3;
            Health = 15;
        }
    }
}
