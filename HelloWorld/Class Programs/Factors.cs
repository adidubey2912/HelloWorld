using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.Class_Programs
{
    class Factors
    {
        public static void FactorsUsingIterativeMethod(int numb)
        {  
            int factor = 1;
            for (int i = 1; i <= numb; i++)
            {
                factor= factor*i;
            }
            Console.WriteLine("Factor of {0}! is {1}.", numb, factor);
        }

        public static int FactorsUsingRecursiveMethod(int numb)
        {
            int factor = numb;
            factor = factor * FactorsUsingRecursiveMethod(numb - 1);
            Console.WriteLine("Factor of {0}! is {1}.", numb, factor);
            return factor;
        }
    }
}
