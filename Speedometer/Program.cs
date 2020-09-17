using System;

namespace Speedometer
{
    class Program
    {
        static void Main(string[] args)
        {
            /*The program asks for distance and time as input and displays the speed in kilometers per hour*/
            
            int speed;
            double kph;
            int time;
            Console.WriteLine("Enter covered distance in km: ");
            speed = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter time spent in hour: ");
            time = int.Parse(Console.ReadLine());
            kph = (speed / time);
            Console.WriteLine($"your speed is {kph} kph");





        }
    }
}
