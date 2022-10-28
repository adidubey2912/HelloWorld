using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelloWorld.Class_Programs;
using HelloWorld.Classes;

namespace HelloWorld
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please choose any one program from below options");
            Console.WriteLine("1. Largest Among Three Numbers\n2. Check Vowel Or Consonant\n3. Check Even Or Odd\n4. Array Concept\n5. Find Factor By Iterative Method\n6. Check Prime Numbers\n7. Find Factor By Recursive Method\n8. Find Greater Number\n9. Check Palindrome Number");
            int choose = Convert.ToInt32(Console.ReadLine());
            switch (choose)
            {
                case 1:
                    int a = Convert.ToInt32(Console.ReadLine());
                    int b = Convert.ToInt32(Console.ReadLine());
                    int c = Convert.ToInt32(Console.ReadLine());
                    LargestAmongThreeNumbers.FindLargest(a, b, c);
                    break;
                case 2:
                    Console.WriteLine("Please enter character");
                    string input = Console.ReadLine();
                    VowelOrConsonant.FindVowelOrConsonant(input);
                    break;
                case 3:
                    EvenOrOdd.FindEvenNumb();
                    break;
                case 4:
                    ArrayConcept arrayClass=new ArrayConcept();
                    arrayClass.ReadMultipleUserInputs();
                    break;
                case 5:
                    Console.WriteLine("Please enter number");
                    int fact = Convert.ToInt32(Console.ReadLine());
                    Factors.FactorsUsingIterativeMethod(fact);
                    break;
                case 6:
                    Console.WriteLine("Please enter number");
                    int num = Convert.ToInt32(Console.ReadLine());
                    PrimeNumbers.FindPrime(num);
                    break;
                case 7:
                    Console.WriteLine("Please enter number");
                    int facta = Convert.ToInt32(Console.ReadLine());
                    Factors.FactorsUsingRecursiveMethod(facta);
                    break;
                case 8:
                    CheckGreater.CheckTheGreater();
                    break;
                case 9:
                    Palindrome.CheckPalindrome();
                    break;
                default:
                    Console.WriteLine("Please select option in showing options");
                    break;
            }
            Console.ReadLine();
        }
    }
}
