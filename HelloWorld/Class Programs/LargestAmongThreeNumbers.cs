using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.Class_Programs
{
    public class LargestAmongThreeNumbers
    {
        public static void FindLargest(int first, int second, int third)
        {
            if (first >= second && first >= third)
                Console.WriteLine("{0} is greater number.", first);
            else if (second >= first && second >= third)
                Console.WriteLine("{0} is greater number.", second);
            else if (third >= first && third >= second)
                Console.WriteLine("{0} is greater number.", third);
            else
                Console.WriteLine("May be all are equel.");
        }
    }
}
