using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.Class_Programs
{
    public class ArrayConcept
    {
        public int[] arr;
        public void ReadMultipleUserInputs() 
        {
            Console.WriteLine("How many numbers want to enter:");
            int n = Convert.ToInt32(Console.ReadLine());
            arr = new int[n];

            for (int i = 0; i < n; i++) 
            {
                Console.WriteLine("Please enter {0}'s element",i+1);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Displaying all array elements");
            for(int i = 0; i < arr.Length; i++) 
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
