namespace Exercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n Volume de um Cilindro");

            Cilindro cilindro = new Cilindro();

            Console.Write("\n Digite o raio do cilindro(em metros): ");
            cilindro.raio = Convert.ToDecimal(Console.ReadLine());

            Console.Write("\n Digite a altura do cilindro(em metros): ");
            cilindro.altura = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("\n O volume do cilindro, em metros cubicos, é: {0:F2}", cilindro.CalcularVolume());
        }
    }
}