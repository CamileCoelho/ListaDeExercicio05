namespace Exercicio05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n Converter a temperatura de graus Celsius para graus Fahrenheit.");

            TemperaturaCelcius temperatura = new TemperaturaCelcius();

            Console.Write("\n Digite a temperatura em graus Celsius: ");

            temperatura.tempCelsius = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\n A temperatura em graus Fahrenheit é: {0:F2} ", temperatura.ConverterTemperaturaParaFahrenheit());
        }
    }
}