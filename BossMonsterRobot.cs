using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class BossMonsterRobot : Robot
    {
        public int ultima;
        public BossMonsterRobot()
        {
            ultima = 50;
            robotName = "Boss";
            Health = 1000;
        }
    }
}
