using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExercise
{
    static class TempConverter
    {
        public static double FahrenheitToCelsius(double fahrenheit)
        {
            double celsius = 5.0 / 9 * (fahrenheit - 32);
            return celsius; 
        }
        public static double CelsiusToFahrenheit(double celsius)
        {
            double fahrenheit = (9.0 / 5 * celsius) + 32;
            return fahrenheit;
        }
    }
}
