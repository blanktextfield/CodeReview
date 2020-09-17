using System;

namespace SumOfTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            int result;
            /*The program asks the user to enter two numbers and prints out the sum of these numbers*/
            Console.WriteLine("Enter your first number: ");
            num1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter your second number: ");
            num2 = Int32.Parse(Console.ReadLine());
             result = (num1 + num2);
            Console.WriteLine($"sum number {result}");

        }
    }
}
