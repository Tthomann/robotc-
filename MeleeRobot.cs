using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class MeleeRobot : Robot
    {
        public int CriticalDamageModifier;
        
        public MeleeRobot()
        {
            robotName = "Sword Robot";
            CriticalDamageModifier = 5;
            Health = 10;
        }
    }
}
