using System;

namespace _07_Task
{
    class Program
    {
        public static string Reverse(string number)
        {
            char[] charArray = number.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            string number = Console.ReadLine();

            Console.WriteLine(Reverse(number));
        }
    }
}
