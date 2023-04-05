namespace Exercicio08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n Volume de uma lata de óleo");

            LataDeOleo latinha = new LataDeOleo();  

            Console.Write("\n Digite o raio da lata de óleo,em metros,(o raio é a metade do diâmetro da lata): ");
            latinha.raio = Convert.ToDecimal(Console.ReadLine());

            Console.Write("\n Digite a altura da lata de óleo(em metros): ");
            latinha.altura = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("\n O volume da lata de óleo, em metros cubicos, é: {0:F2}", latinha.CalcularVolume());
        }
    }
}