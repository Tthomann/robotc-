using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class MonsterRobot : Robot
    {
        public int RegenHealth;
       public MonsterRobot()
        {
            RegenHealth = 2;
            Health = 7;
        }
    }
}
