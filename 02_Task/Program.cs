using System;

namespace _02_Task
{
    class Program
    {
        static int a;

        static void GetMax(int first, int second)
        {
            if (first > second) a = first;
            else a = second;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            a = Int32.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int b = Int32.Parse(Console.ReadLine());
            Console.Write("Enter third number: ");
            int c = Int32.Parse(Console.ReadLine());

            GetMax(a, b);
            GetMax(a, c);

            Console.WriteLine("Biggest number is {0}", a);
        }
    }
}
