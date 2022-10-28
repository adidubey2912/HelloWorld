using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.Class_Programs
{
    class Palindrome
    {
        public static void CheckPalindrome()
        {
            int rem, result = 0, temp;
            Console.WriteLine("Enter the number");
            int num = Convert.ToInt32(Console.ReadLine());
            temp = num;
            while (num != 0)
            {
                rem = num % 10;
                num = num / 10;
                result = (result * 10) + rem;
            }

            if (temp == result)
            {
                Console.WriteLine("It is palindrome number.");
            }
            else
            {
                Console.WriteLine("It is not a palindrome number.");
            }  
        }
    }
}
