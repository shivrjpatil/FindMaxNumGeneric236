using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace FindMaxNum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("choose one option to select following program");
            Console.WriteLine("1.To Find Maximum Integer Number\n2.To find maimum float Number\n3.To Find Maximum String\n4.To find maximum Numbers Using generic method  ");
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
                case 4:
                  { 
                    //INTEGER INPUT
                    Console.WriteLine("Enter First Integer Number");
                    int firstInt = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Second Integer Number");
                    int secondInt = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Third Integer Number");
                    int thirdInt = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Max Value:" + FindMaxUsinggeneric<int>.GenericMaxNumber(firstInt, secondInt, thirdInt));
                    //FLOAT INPUT
                    Console.WriteLine("Enter First float Number");
                    float firstFloat = Convert.ToSingle(Console.ReadLine());
                    Console.WriteLine("Enter Second float Number");
                    float secondFloat = Convert.ToSingle(Console.ReadLine());
                    Console.WriteLine("Enter Third float Number");
                    float thirdFloat = Convert.ToSingle(Console.ReadLine());
                    Console.WriteLine("Max Value:" + FindMaxUsinggeneric<float>.GenericMaxNumber(firstFloat, secondFloat, thirdFloat));
                    //STRING INPUT
                    Console.WriteLine("Enter First string");
                    string firstString = Console.ReadLine();
                    Console.WriteLine("Enter string");
                    string secondString = Console.ReadLine();
                    Console.WriteLine("Enter Third string");
                    string thirdString = Console.ReadLine();
                    Console.WriteLine("Max Value:" + FindMaxUsinggeneric<string>.GenericMaxNumber(firstString, secondString, thirdString));
                  }
                    break;
                case 5:
                    {  //RefCTOR-2

                        //INTEGER
                        Console.WriteLine("Enter First Integer Number");
                        int firstInt = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Second Integer Number");
                        int secondInt = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Third Integer Number");
                        int thirdInt = Convert.ToInt32(Console.ReadLine());
                        FindMaxUsinggeneric<int> obj = new FindMaxUsinggeneric<int>(firstInt, secondInt, thirdInt);
                        obj.TestMaximum();
                        //FLOATS
                        Console.WriteLine("Enter First float Number");
                        float firstFloat = Convert.ToSingle(Console.ReadLine());
                        Console.WriteLine("Enter Second float Number");
                        float secondFloat = Convert.ToSingle(Console.ReadLine());
                        Console.WriteLine("Enter Third float Number");
                        float thirdFloat = Convert.ToSingle(Console.ReadLine());
                        FindMaxUsinggeneric<float> obj2 = new FindMaxUsinggeneric<float>(firstFloat, secondFloat, thirdFloat);
                        obj2.TestMaximum();
                        //STRING
                        Console.WriteLine("Enter First string");
                        string firstString = Convert.ToString(Console.ReadLine());
                        Console.WriteLine("Enter string");
                        string secondString = Convert.ToString(Console.ReadLine());
                        Console.WriteLine("Enter Third string");
                        string thirdString = Convert.ToString(Console.ReadLine());
                        FindMaxUsinggeneric<string> obj3 = new FindMaxUsinggeneric<string>(firstString, secondString, thirdString);
                        obj3.TestMaximum();
                    }
                    break;
            }
        }
    }
}
