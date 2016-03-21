using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        int uInput = Convert.ToInt32(Console.ReadLine());
        static void Main(string[] args)
        {
            PlayerSelectOption select = new PlayerSelectOption();
            select.OptionSelect();
            Console.ReadLine();
            }
        }
    }

