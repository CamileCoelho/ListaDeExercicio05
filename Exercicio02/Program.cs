namespace Exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n Converter a temperatura de graus Fahrenheit para graus Celsius.");

            TemperaturaFahrenheit temperatura = new TemperaturaFahrenheit();

            Console.Write("\n Digite a temperatura em graus Fahrenheit: ");

            temperatura.tempFahrenheit = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\n A temperatura em graus Celsius é: {0:F2} ", temperatura.ConverterTemperaturaParaCelcius());

        }
    }
}