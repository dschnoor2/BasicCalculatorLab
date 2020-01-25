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
            int temperatureFahrenheit = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Relative Humidity");
            int relativeHumidity = int.Parse(Console.ReadLine());

            double dewPoint = temperatureFahrenheit -  9 * (100 - relativeHumidity) / 25;

            Console.WriteLine("The Dew Point is " + dewPoint);

            Console.WriteLine("Enter Wind Speed in MPH");
            int windSpeed = int.Parse(Console.ReadLine());

            double windChill = 35.74 + (0.6215 * temperatureFahrenheit) - 35.75 * Math.Pow(windSpeed, 0.16) + 0.4275 * temperatureFahrenheit * Math.Pow(windSpeed, 0.16);

            Console.WriteLine("The Wind Chill is " + windChill);
        }
    }
}
