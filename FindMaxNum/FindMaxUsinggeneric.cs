using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaxNum
{
    public class FindMaxUsinggeneric<T> where T: IComparable
    {
            public T first, second, third;
            public FindMaxUsinggeneric(T first, T second, T third)
            {
                this.first = first;
                this.second = second;
                this.third = third;
            }
        public static T GenericMaxNumber(T first, T second, T third)
        {

            if ((first.CompareTo(second) > 0) && (first.CompareTo(third) > 0))
            {
                return first;
            }
            else if ((second.CompareTo(first) > 0) && (second.CompareTo(third) > 0))
            {
                return second;
            }
            else
            {
                return third;
            }
        }
        public void TestMaximum()
        {
            T res = GenericMaxNumber(first, second, third);
            Console.WriteLine("Max:" + res);
        }
    }
}
