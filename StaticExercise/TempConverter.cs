using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExercise
{
    public static class TempConverter
    {
        public static double FahrenheitToCelsius(double fahrenheitTemp)
        {
            var result = (fahrenheitTemp - 32) * 5/9;

            return result;
        }

        public static double CelciusToFahrenheit(double celsiusTemp)
        {
            var result2 =  (celsiusTemp * (9 / 5)) + 32;
            return result2;
        }
    }
}
