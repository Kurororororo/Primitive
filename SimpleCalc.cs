using System;

namespace TestNameSpace
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Area calculator");

            Console.WriteLine("Enter First Number: ");
            int Num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter operation");
            string operation = Console.ReadLine();

            Console.WriteLine("Enter Second Number: ");
            int Num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The result is: ");

            if (operation == "+")
            {
                Console.WriteLine(Num1 + Num2);
            }
            if (operation == "-")
            {
                Console.WriteLine(Num1 - Num2);
            }
            if (operation == "*")
            {
                Console.WriteLine(Num1 * Num2);
            }
            if (operation == "/")
            {
                Console.WriteLine(Num1 / Num2);
            }

        }
    }
}
