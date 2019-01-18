using System;

namespace Lessons
{
    public static class Utilities
    {
        static int tempMultiplier = 32;

        public static double CelsiusToFahrenheit(string temperature)

        {
            double celsius = Double.Parse(temperature);
            double fahrenheit = (celsius * 9 / 5) + tempMultiplier;
            return fahrenheit;
        }
        public static double FahrenheitToCelsius(string temperature)
        {
            double fahrenheit = Double.Parse(temperature);
            double celsius = (fahrenheit - tempMultiplier) * 5 / 9;
            return celsius;
        }
    }
}