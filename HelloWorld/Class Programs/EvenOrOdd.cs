using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.Classes
{
    public class EvenOrOdd
    {
        public static void FindEvenNumb()
        {
            int numb = 0;
            Console.WriteLine("Please enter number");
            numb = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < numb; i++)
            {
                if (i % 2 == 0)
                    Console.WriteLine("{0} is Even number",i);
                else
                    Console.WriteLine("{0} is Odd number", i);
            }
        }
    }
}
