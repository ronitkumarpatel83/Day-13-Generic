using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_13_Generic
{
    internal class MaxMethod
    {
        public static void Max(int[] arr)
        {

            Array.Sort(arr);
            int max = arr.Length - 1;
            Console.WriteLine("The maximum integer is: " + arr[max]);
        }
    }
}
