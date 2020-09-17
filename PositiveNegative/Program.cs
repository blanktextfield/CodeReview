using System;

namespace PositiveNegative
{
    class Program
    {
        static void Main(string[] args)
        {
            /*The program checks if the number is positive or negative*/
          

            string Userinput; 
            int Number;
            Console.WriteLine("Enter your number: ");
            Userinput = Console.ReadLine();
            Number = Int32.Parse(Userinput);

            if(Number < 0)
            {
                Console.WriteLine("The number is negative.");
            } else if (Number > 0)
            {
                Console.WriteLine("The number is positive.");
            }

        }
    }
}
