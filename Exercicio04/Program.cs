namespace Exercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n Cálculo do consumo de combustível por km.");

            ConsumoCombustivelPorKm consumoCombustivelPorKm = new ConsumoCombustivelPorKm();

            Console.Write("\n Digite o km inicial: ");
            consumoCombustivelPorKm.kmInicial = Convert.ToDouble(Console.ReadLine());

            Console.Write("\n Digite o km final: ");
            consumoCombustivelPorKm.kmFinal = Convert.ToDouble(Console.ReadLine());

            Console.Write("\n Digite o consumo de combustível em litros: ");
            consumoCombustivelPorKm.qtdCombustivel = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\n O consumo de combustível, em litros, por km foi de: {0:F2}", consumoCombustivelPorKm.CalcularConsumo());
        }
    }
}