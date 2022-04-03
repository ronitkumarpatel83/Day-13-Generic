using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_13_Generic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Find Maximum Problem Using Generic");
            Console.WriteLine("<<<<<<<<<<<<<Generic>>>>>>>>>>>>>>>");
            Console.WriteLine();
            Console.WriteLine("Welcome to Greater between 3 integer program ");
            Console.WriteLine("Enter 3 Integer Value");
            int fst = int.Parse(Console.ReadLine());
            int snd = int.Parse(Console.ReadLine());
            int trd = int.Parse(Console.ReadLine());
            MaxInteger.Max(fst, snd, trd);
        }
    }
}
