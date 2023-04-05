namespace Exercicio05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n Cálculo do volume de uma esfera. ");

            Esfera esfera = new Esfera();   

            Console.Write("\n Digite o raio da esfera(em metros): ");
            esfera.raio = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\n O volume da esfera, em metros cubisos, é: {0:F2}", esfera.CalcularVolume());
        }
    }
}