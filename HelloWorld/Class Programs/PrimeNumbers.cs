using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.Class_Programs
{
    public class PrimeNumbers
    {
        public static void FindPrime(int numb) 
        {
            int factor = 0;
            for (int i = 1; i <= numb; i++)
            {
                if (numb % i == 0)
                {
                    factor = factor + 1;
                }
            }
            if (factor > 2)
            {
                Console.WriteLine("{0} is not prime.",numb);
            }
            else
            {
                Console.WriteLine("{0} is prime.",numb);
            }
        }
    }
}
