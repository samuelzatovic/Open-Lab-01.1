using System;

namespace Open_Lab_01._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, insert a number between " + int.MinValue + " and " + int.MaxValue);
            string line;
            line = Console.ReadLine();

            if (line == null || line == "") {
                Console.WriteLine("Empty input");
                return;
            }
            int number;
            if (!int.TryParse(line, out number))
            {
                Console.WriteLine("Wrong input");
                return;
            }
            if (number >= 10)
            {
                Console.WriteLine("This number is greater or equal to 10.");
            }
            else
            {
                Console.WriteLine("This number is less then 10.");
            }
           

        }
    }
}
