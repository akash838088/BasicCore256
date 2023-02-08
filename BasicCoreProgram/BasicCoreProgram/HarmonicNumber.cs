using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProblem
{
    internal class HarmonicNumber
    {
        public static void harmonic()
        {
            double harmonic = 0.0;
            Console.WriteLine("ENETER A NUMBER HERE");
            int x = Convert.ToInt32(Console.ReadLine());
            if (x != 0)
            {
                for (int i = 1; i <= x; i++)
                {
                    harmonic += 1 / (double)i;
                    Console.WriteLine(" its value of harmonic series :" + harmonic);
                    Console.Write("1/{0} + ", i);
                    //1/1+1/2+1/3+1/4......1/n +  
                }
                Console.WriteLine(" its value of harmonic series : " + harmonic);
            }
            else
            {
                Console.WriteLine("please valid number");
            }

        }
    }
}
