using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaxNum
{
    internal class FindmaxFloatNum
    {
        public static void MaxFloatNumber()          
        {
            Console.WriteLine("Enter First Float Number");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Second Float Number");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Third Float Number");
            double c = Convert.ToDouble(Console.ReadLine());
            if ((a.CompareTo(b) > 0) && (a.CompareTo(c) > 0))
            {
                Console.WriteLine("The maximum number is:" + a);
            }
            else if ((b.CompareTo(a) > 0) && (b.CompareTo(c) > 0))
            {
                Console.WriteLine("The maximum number is: " + b);
            }
            else
            {
                Console.WriteLine("The maximum number is : " + c);
            }
            Console.ReadLine();
        }
    }
}
