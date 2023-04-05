namespace ListaDeExercicios05.Exercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Volume de uma caixa retangular. ");
            Console.WriteLine();

            CaixaRetangular caixa = new CaixaRetangular();

            Console.Write("Digite a altura da caixa(em metros): ");
            caixa.altura = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Digite a largura da caixa(em metros): ");
            caixa.largura = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Digite o comprimento da caixa(em metros): ");
            caixa.comprimento = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("O volume da caixa é: " + caixa.CalcularVolume() + "m³");
        }
    }
}