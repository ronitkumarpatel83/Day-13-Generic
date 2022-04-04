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
            Console.WriteLine("1.Find maximum of three Integer number\n2.Find maximum of three Float number");
            Console.WriteLine("3.Find maximum of string\n4.Refactor 1\n5.Refactor 2");
            Console.WriteLine("6.Max Method ");
            Console.WriteLine("Enter your choice : ");
            int ch = Convert.ToInt32(Console.ReadLine());   // Storing user's choice
            switch (ch)
            {
                case 1:
                    Console.WriteLine("Welcome to Greater between 3 integer program ");
                    Console.WriteLine("Enter 3 Integer Value");
                    int fst = int.Parse(Console.ReadLine());
                    int snd = int.Parse(Console.ReadLine());
                    int trd = int.Parse(Console.ReadLine());
                    MaxInteger.Max(fst, snd, trd);
                    break;
                case 2:
                    Console.WriteLine("Welcome to Greater between 3 Floats program ");
                    Console.WriteLine("Enter 3 Floats Value");
                    double f = double.Parse(Console.ReadLine());
                    double s = double.Parse(Console.ReadLine());
                    double t = double.Parse(Console.ReadLine());
                    MaxFloat.Float(f, s, t);
                    break;
                case 3:
                    Console.WriteLine("Welcome to Greater between 3 Strings program ");
                    Console.WriteLine("Enter 3 String");
                    string a = Console.ReadLine();
                    string b = Console.ReadLine();
                    string c = Console.ReadLine();
                    MaxString.String(a,b,c);
                    break;
                case 4:
                    Console.WriteLine("Welcome to program ");

                    Refactor1<int> refactorint = new Refactor1<int>();
                    int max1 = refactorint.MaxValue(10, 20, 30);
                    Console.WriteLine("Maximum value of int is : " + max1);

                    Refactor1<double> refactorfloat = new Refactor1<double>();
                    double max2 = refactorfloat.MaxValue(10.10, 20.20, 30.30);
                    Console.WriteLine("Maximum value of float is : " + max2);

                    Refactor1<string> refactorstring = new Refactor1<string>();
                    string max3 = refactorstring.MaxValue("Ronit", "Kumar", "Patel");
                    Console.WriteLine("Maximum value of string is : " + max3);
                    break;
                case 5:
                    Refactor2<int> refactor2int = new Refactor2<int>(10, 20, 30);
                    int m1 = refactor2int.MaxValueOf(10, 20, 30);
                    Console.WriteLine("Maximum value of int is: " + m1);

                    Refactor2<double> refactor2float = new Refactor2<double>(10.10, 20.20, 30.30);
                    double m2 = refactor2float.MaxValueOf(10.10, 20.20, 30.30);
                    Console.WriteLine("Maximum value of float is: " + m2);

                    Refactor2<string> refactor2string = new Refactor2<string>("Abhi", "avi", "lol");
                    string m3 = refactor2string.MaxValueOf("Ronit", "kumar", "Patel");
                    Console.WriteLine("Maximum value of string is: " + m3);
                    break;
                case 6:
                    Console.WriteLine("Welcome to program ");
                    Console.WriteLine("Enter Length of Array");
                    int len = int.Parse(Console.ReadLine());
                    int[] arr = new int[len];
                    Console.WriteLine("Enter elements of array");
                    for (int i = 0; i < arr.Length; i++)
                    {
                        arr[i] = int.Parse(Console.ReadLine());
                    }

                    MaxMethod.Max(arr);
                    break;
                default:
                    Console.WriteLine("Please Enter a valid number");
                    break;
                
            }
            
        }
    }
}
