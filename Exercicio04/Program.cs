namespace Exercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n Cálculo do consumo de combustível por km.");

            ConsumoCombustivelPorKm viagemCasa = new ConsumoCombustivelPorKm();

            Console.Write("\n Digite o km inicial: ");
            viagemCasa.kmInicial = Convert.ToDouble(Console.ReadLine());

            Console.Write("\n Digite o km final: ");
            viagemCasa.kmFinal = Convert.ToDouble(Console.ReadLine());

            Console.Write("\n Digite o consumo de combustível em litros: ");
            viagemCasa.qtdCombustivel = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\n O consumo de combustível, em litros, por km foi de: {0:F2}", viagemCasa.CalcularConsumo());
        }
    }
}