namespace Exercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Console.WriteLine("\n Cálculo da média ponderada de duas notas de um Aluno.");

            Notass notasAluno = new Notass();

            Console.Write("\n Digite a nota que tirou na primeira prova: ");
            notasAluno.primeiraNota = Convert.ToDecimal(Console.ReadLine());

            Console.Write("\n Digite o peso da primeira prova: ");
            notasAluno.pesoPrimeiraNota = Convert.ToDecimal(Console.ReadLine());

            Console.Write("\n Digite a nota que tirou na segunda prova: ");
            notasAluno.segundaNota = Convert.ToDecimal(Console.ReadLine());

            Console.Write("\n Digite o peso da segunda prova: ");
            notasAluno.pesoSegundaNota = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("\n A média harmônica é: {0:F2} ", notasAluno.CalCularMediaPonderada());
        }
    }
}