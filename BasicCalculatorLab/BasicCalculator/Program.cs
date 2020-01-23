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
            int Temp = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Relative Humdidity");
            int RH = int.Parse(Console.ReadLine());

            decimal dewPoint = Temp -  9 *(100 - RH) / 25;

            Console.WriteLine("The answer is " + dewPoint);
        }
    }
}
