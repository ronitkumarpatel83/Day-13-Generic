using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_13_Generic
{
    internal class Refactor2<T> where T : IComparable
    {
        public T first, second, third;

        public Refactor2(T first, T second, T third)
        {
            this.first = first;
            this.second = second;
            this.third = third;
        }
        public T MaxValueOf(T first, T second, T third)
        {
            if (first.CompareTo(second) > 0 && first.CompareTo(third) > 0 ||
                    first.CompareTo(second) >= 0 && first.CompareTo(third) > 0 ||
                    first.CompareTo(second) > 0 && first.CompareTo(third) >= 0)
            {
                Console.WriteLine("First Value is maximum" + first);
                return first;
            }

            if (second.CompareTo(first) > 0 && second.CompareTo(third) > 0 ||
                    second.CompareTo(first) >= 0 && second.CompareTo(third) > 0 ||
                    second.CompareTo(first) > 0 && second.CompareTo(third) >= 0)
            {
                Console.WriteLine("Second Value is Maximum " + second);
                return second;
            }
            if (third.CompareTo(second) > 0 && third.CompareTo(first) > 0 ||
                    third.CompareTo(second) >= 0 && third.CompareTo(first) > 0 ||
                    third.CompareTo(second) > 0 && third.CompareTo(first) >= 0)
            {
                Console.WriteLine("Third Value is maximum" + third);
                return third;
            }
            if (first.CompareTo(second) == 0 && first.CompareTo(third) == 0 && second.CompareTo(third) == 0)
            {
                Console.WriteLine("All three Values are same");
            }
            return default;
        }
    }

}
