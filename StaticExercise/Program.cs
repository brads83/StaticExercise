using System;

namespace StaticExercise
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("Please enter a temperature to convert to Fahrenheit");
            //Console.ReadLine() = 
            
            Console.WriteLine($"Temp is {TempConverter.CelsiusToFahrenheit(45)}");

            //Console.WriteLine("Please enter a temperature to convert to Celsius");
            //Console.ReadLine() =
            Console.WriteLine($"Celsius temp is {TempConverter.FahrenheitToCelsius(45)}");
        }

        
        

    }
}
