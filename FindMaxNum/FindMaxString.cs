using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaxNum
{
    internal class FindMaxString
    {
        public static void MaxString()          
        {
            Console.WriteLine("Enter First String");
            string a = Console.ReadLine();
            Console.WriteLine("Enter Second String");
            string b = Console.ReadLine();
            Console.WriteLine("Enter Third String");
            string c = Console.ReadLine();
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
