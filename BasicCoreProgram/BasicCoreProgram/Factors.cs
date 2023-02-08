using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProblem
{
    internal class factor
    {
        public static void main()
        {
            int factor = 1;
            Console.WriteLine("ENTER NUMBER HERE");
            int x = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= x; i++)
            {
                factor = factor * i;
            }
            Console.WriteLine("fact of given number is : " + factor);
        }
    }
}