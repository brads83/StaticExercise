using System;
using System.Collections.Generic;
using System.Text;

namespace StaticExercise
{
    public static class TempConverter
    {
        static TempConverter()
        {
        }

        public static double FahrenheitToCelsius(double x)
        {
            double temp = (x - 32) * (5) / 9);
            return temp;
            //Console.WriteLine("(F - 32) x 5/9 = C");
        }
        public static double CelsiusToFahrenheit (double x)
        {
            double temp = (x * 9)/5 + 32;
            return temp;
            //Console.WriteLine("C x 9/5) + 32 = F");
        }

    }
}
