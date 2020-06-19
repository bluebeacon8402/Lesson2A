using System;

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();
            Console.WriteLine($"My name is {name}");
            Console.WriteLine("What is your favorite color?");
            var color = Console.ReadLine();
            Console.WriteLine($"My favorite color is {color}");
            Console.WriteLine("What is your favorite animal?");
            var animal = Console.ReadLine();
            Console.WriteLine($"My favorite animal is {animal}");
            Console.WriteLine("What is your favorite band?");
            var band = Console.ReadLine(); 
            Console.WriteLine($"My favorite band is the {band}");
            var message = MyString(name, color, animal, band);
            Console.WriteLine(message);
        }
        public static string MyString(string name, string color, string animal, string band)
        {
            return $"Hello, My name is {name} and my favorite color is {color}. I really like {animal} and my favorite band is {band}";
        }
    }
}
