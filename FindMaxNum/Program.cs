using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaxNum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("choose one option to select following program");
            Console.WriteLine("1.To Find Maximum Integer Number\n2.To find maimum float Number\n3.To Find Maximum String ");
            int option =Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    FindMaxIntNum.MaxIntNumber();
                    break;
                case 2:
                    FindmaxFloatNum.MaxFloatNumber();
                    break;
                case 3:
                    FindMaxString.MaxString();
                    break;
            }
        }
    }
}
