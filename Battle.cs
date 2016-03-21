using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Battle
    {
       public  MeleeRobot SwordRobot = new MeleeRobot();
        public ShootingRobot GunRobot = new ShootingRobot();
        public MonsterRobot Mrobot = new MonsterRobot();
        public BossMonsterRobot Brobot = new BossMonsterRobot();
        public Battle()
        {

        }
        public void SvMInstance()
        {
            Random turnRng = new Random();
            Random rngDamage = new Random();

            while (SwordRobot.Health > 0 && Mrobot.Health > 0 && Brobot.Health >0)
            {
                int Chance = turnRng.Next(0, 10);
                int AttackDamage = rngDamage.Next(1, 4);
                if (Chance <= 4)
                {

                    Console.WriteLine("Monster Robot strikes the Sword Robot dealing " + AttackDamage + " damage!");
                    SwordRobot.Health = SwordRobot.Health - AttackDamage;
                    Console.WriteLine("Sword Robot has " + SwordRobot.Health + " remaining!");
                    Console.WriteLine("hit enter to continue the fight!");
                    Console.ReadLine();
                }
                else if (Chance == 7)
                {
                    Console.WriteLine("Monster robot uses Regen! it has healed " + Mrobot.RegenHealth + " damage!");
                    Mrobot.Health = Mrobot.RegenHealth * Mrobot.Health;
                    Console.WriteLine("Monster robot has " + Mrobot.Health + " Remaining!");
                    Console.WriteLine("hit enter to continue the fight!");
                    Console.ReadLine();
                }
                else if (Chance > 5)
                {
                    Console.WriteLine("Sword Robot strikes the Monster Robot dealing " + AttackDamage + " damage!");
                    Mrobot.Health = Mrobot.Health - AttackDamage;
                    Console.WriteLine("Monster Robot has " + Mrobot.Health + " remaining!");
                    Console.WriteLine("hit enter to continue the fight!");
                    Console.ReadLine();

                }
                else if (Chance == 9)
                {
                    Console.WriteLine("Sword Robot has done Critical Damage ");
                    Mrobot.Health = AttackDamage * SwordRobot.CriticalDamageModifier;
                    Console.WriteLine("Monster robot has " + Mrobot.Health + " Remaining!");
                    Console.WriteLine("hit enter to continue the fight!");
                    Console.ReadLine();
                }
                
                else
                {

                    Console.WriteLine("BOSS MONSTER HAS APPEARED, USING IT'S ULTIMA BLAST WITH " + Brobot.ultima + " DAMAGE!!!");
                    GunRobot.Health = AttackDamage - Brobot.ultima;
                    Console.WriteLine("Gun Robot has " + GunRobot.Health + " remaining! ");
                    Console.ReadLine();
                    break;
                }
              


            }
        }

        public void GvMInstance()
        {
            Random turnRng = new Random();
            Random rngDamage = new Random();

            while (GunRobot.Health > 0 && Mrobot.Health > 0 && Brobot.Health > 0)
            {
                int Chance = turnRng.Next(0, 10);
                int AttackDamage = rngDamage.Next(1, 4);
                if (Chance <= 4)
                {

                    Console.WriteLine("Monster Robot strikes the Gun Robot dealing " + AttackDamage + " damage!");
                    GunRobot.Health = GunRobot.Health - AttackDamage;
                    Console.WriteLine("Sword Robot has " + GunRobot.Health + " remaining!");
                    Console.WriteLine("hit enter to continue the fight!");
                    Console.ReadLine();
                }
                else if (Chance == 7)
                {
                    Console.WriteLine("Monster robot uses Regen! it has healed " + Mrobot.RegenHealth + " damage!");
                    Mrobot.Health = Mrobot.RegenHealth * Mrobot.Health;
                    Console.WriteLine("Monster robot has " + Mrobot.Health + " Remaining!");
                    Console.WriteLine("hit enter to continue the fight!");
                    Console.ReadLine();
                }
                else if (Chance > 5)
                {
                    Console.WriteLine("Gun Robot strikes the Monster Robot dealing " + AttackDamage + " damage!");
                    Mrobot.Health = Mrobot.Health - AttackDamage;
                    Console.WriteLine("Monster Robot has " + Mrobot.Health + " remaining!");
                    Console.WriteLine("hit enter to continue the fight!");
                    Console.ReadLine();

                }
                else if (Chance == 9)
                {
                    Console.WriteLine("Gun Robot has fire it's ULTIMATE LAZER ");
                    Mrobot.Health = AttackDamage * GunRobot.KamikazeModifier;
                    Console.WriteLine("Monster robot has " + Mrobot.Health + " Remaining!");
                    Console.WriteLine("hit enter to continue the fight!");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("BOSS MONSTER HAS APPEARED, USING IT'S ULTIMA BLAST!");
                    GunRobot.Health = AttackDamage - Brobot.ultima;
                    Console.WriteLine("Gun Robot has " + GunRobot.Health + " remaining! ");
                    Console.ReadLine();
                    break;
                }
            

            }
            
        }
    }
}
