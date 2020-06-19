using System;
using System.ComponentModel;

namespace Lesson2B
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var name = Console.ReadLine();
            var result = Add(10, 20);
            
            int addition = Add(2, 3);
            int timesBy = Multiply(4, 5);
            Console.WriteLine(addition);
            Console.WriteLine(timesBy);
        }

        public static int Add(int num1, int num2)
        {
            int sum = num1 + num2;
            return sum;
        }

        public static int Multiply(int num1, int num2)
        {
            int mult = num1 * num2;
            return mult;
        }
    }
}
