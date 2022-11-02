namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {

            var celcius = TempConverter.FahrenheitToCelsius(30); 
            var fahrenheit = TempConverter.CelciusToFahrenheit(30);


            Console.WriteLine("Conversion ");
            Console.WriteLine($"celcius {celcius}");
            Console.WriteLine($"fahrenheit {fahrenheit}");

        }

        
    }
}
