using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_13_Generic
{
    internal class MaxString
    {
        public static string String(string first, string second, string third)
        {
            if (first.CompareTo(second) > 0 && first.CompareTo(third) > 0 ||
                    first.CompareTo(second) >= 0 && first.CompareTo(third) > 0 ||
                    first.CompareTo(second) > 0 && first.CompareTo(third) >= 0)
            {
                Console.WriteLine("First String is maximum : " + first);
                return first;
            }

            if (second.CompareTo(first) > 0 && second.CompareTo(third) > 0 ||
                    second.CompareTo(first) >= 0 && second.CompareTo(third) > 0 ||
                    second.CompareTo(first) > 0 && second.CompareTo(third) >= 0)
            {
                Console.WriteLine("Second String is Maximum : " + second);
                return second;
            }
            if (third.CompareTo(second) > 0 && third.CompareTo(first) > 0 ||
                    third.CompareTo(second) >= 0 && third.CompareTo(first) > 0 ||
                    third.CompareTo(second) > 0 && third.CompareTo(first) >= 0)
            {
                Console.WriteLine("Third String is maximum : " + third);
                return third;
            }
            if (first.CompareTo(second) == 0 && first.CompareTo(third) == 0 && second.CompareTo(third) == 0)
            {
                Console.WriteLine("All three Strings are same");
            }
            return first;
        }
    }
}
