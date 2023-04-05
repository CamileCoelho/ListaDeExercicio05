namespace Exercicio07
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("\n Cálculo do salário total de um vendedor.");

            SalarioTotal salario = new SalarioTotal(); 

            Console.Write("\n Informe o salário base: ");
            salario.salarioBase = Convert.ToDecimal(Console.ReadLine());

            Console.Write("\n Informe o total de vendas: ");
            salario.totalVendas = Convert.ToDecimal(Console.ReadLine());

            Console.Write("\n Informe a comissão (em %): ");
            salario.comissao = Convert.ToDecimal(Console.ReadLine()) / 100;

            Console.WriteLine("Salário total: R$ " + salario.CalcularSalarioTotal().ToString("F2"));
        }
    }
}