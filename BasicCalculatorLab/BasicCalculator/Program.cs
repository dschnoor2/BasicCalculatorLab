using System;

namespace BasicCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** BASIC WEATHER CALCULATOR ***");

            // Ask user for Temp
            Console.WriteLine("Enter Temperature in Fahrenhiet");

            // int.Parse will take a string data type and convert it to an int data type
            int temperatureFahrenheit = int.Parse(Console.ReadLine());

            // Ask user for Relative Humidity
            Console.WriteLine("Enter Relative Humidity");
            int relativeHumidity = int.Parse(Console.ReadLine());

            // Calculate Dew Point
            double dewPoint = temperatureFahrenheit -  9 * (100 - relativeHumidity) / 25;

            // Print Dew Point
            Console.WriteLine("The Dew Point is " + dewPoint);

            // Ask user for wind speed
            Console.WriteLine("Enter Wind Speed in MPH");
            int windSpeed = int.Parse(Console.ReadLine());

            // Calculate Wind Chill
            double windChill = 35.74 + (0.6215 * temperatureFahrenheit) - 35.75 * Math.Pow(windSpeed, 0.16) + 0.4275 * temperatureFahrenheit * Math.Pow(windSpeed, 0.16);

            // Print Wind Chill
            Console.WriteLine("The Wind Chill is " + windChill);
        }
    }
}
