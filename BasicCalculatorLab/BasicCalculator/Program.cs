using System;

namespace BasicCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** BASIC CALCULATOR ***");

            Console.WriteLine("Enter Temperature in Fahrenhiet");

            // int.Parse will take a string data type and convert it to an int data type
            int tempFahr = int.Parse(Console.ReadLine()); //tempFahr = Temperature in Fahrenheit

            Console.WriteLine("Enter Relative Humidity");
            int rH = int.Parse(Console.ReadLine());  //rH = Relative Humidity

            double dewPoint = tempFahr -  9 * (100 - rH) / 25;

            Console.WriteLine("The Dew Point is " + dewPoint);

            Console.WriteLine("Enter Wind Speed");
            int windSpeed = int.Parse(Console.ReadLine());

            double windChill = 35.74 + (0.6215 * tempFahr) - 35.75 * Math.Pow(windSpeed, 0.16) + 0.4275 * tempFahr * Math.Pow(windSpeed, 0.16);

            Console.WriteLine("The Wind Chill is " + windChill);
        }
    }
}
