using StaticExercise;

namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Fahrenheit TO Celsius: {TempConverter.FahrenheitToCelsius(32)}");
         

            Console.Write($"Celsius TO Fahrenheit: {TempConverter.CelsiusToFahrenheit(0)} ");
          
        }


       

    }
}
