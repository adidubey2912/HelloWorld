using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.Classes
{
    public class VowelOrConsonant
    {
        public static void FindVowelOrConsonant(string input)
        {
            if (input.ToLower().Equals("a") || input.ToLower().Equals("e") || input.ToLower().Equals("i") || input.ToLower().Equals("o") || input.ToLower().Equals("u"))

                Console.WriteLine("{0} is Vowel", input);
            else
                Console.WriteLine("{0} is Consonant", input);
        }
    }
}