using System;

namespace _04_Task
{
    class Program
    {
        static int CountNumber(int number, int[] arr)
        {
            int counter = 0;

            for (int i = 0; i < arr.Length; i++) if (number == arr[i]) counter++;

            return counter;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter array length: ");
            int length = Int32.Parse(Console.ReadLine());

            int[] arr = new int[length];

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Enter {0} element: ", i);
                arr[i] = Int32.Parse(Console.ReadLine());
            }

            Console.Write("Enter number: ");
            int number = Int32.Parse(Console.ReadLine());

            Console.WriteLine("{0} was found {1} times.", number, CountNumber(number, arr));
        }
    }
}
