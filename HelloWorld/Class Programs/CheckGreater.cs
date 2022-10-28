using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.Class_Programs
{
    class CheckGreater
    {
        public static void CheckTheGreater()
        {

            Console.WriteLine("Enter the 1st number:");
            int X = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the 2nd number:");
            int Y = Convert.ToInt32(Console.ReadLine());

            if (X > Y)
                Console.WriteLine("The greater number is {0}", X);
            else
                Console.WriteLine("The greater number is {0}", Y);
        }
    }
}
