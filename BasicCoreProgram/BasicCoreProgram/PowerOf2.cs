using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProblem
{
    internal class power
    {
        public static void pow()
        {

            Console.WriteLine("ENTER NUMBER HERE TO FIND 2^N POWER");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The 2 Power of " + x + " is");
            Console.WriteLine(Math.Pow(2, x));
        }
    }
}
