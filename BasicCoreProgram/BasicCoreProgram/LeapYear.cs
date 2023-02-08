using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProblem
{
    internal class LeapYear
    {
        public static void LEAP()
        {
            Console.WriteLine("ENTER YEAR HERE");
            int x = Convert.ToInt32(Console.ReadLine());
            if (x % 4 == 0)
            {
                Console.WriteLine(x + " : IS A LEAP YEAR");
            }
            else
            {
                Console.WriteLine(x + " : IS NOT A LEAP YEAR");
            }
        }
    }
}