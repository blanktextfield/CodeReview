using System;

namespace ToLower
{
    class Program
    {
        static void Main(string[] args)
        {
            /*A program asks the user to write a word in Uppercase and displays this input in lowercase*/
            string UserInput;
            Console.WriteLine("Enter an uppercase word: ");
             UserInput = Console.ReadLine().ToLower();
            Console.WriteLine(UserInput);            
        }   
    }
}
