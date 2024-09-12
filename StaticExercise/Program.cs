namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"100°F = {TempConverter.FahrenheitToCelsius(100)}°C ");
            Console.WriteLine("");
            Console.WriteLine($"32°C = {TempConverter.CelsiusToFahrenheit(32)}°F");
        }
    }
}
