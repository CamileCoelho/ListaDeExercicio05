namespace Exercicio09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Console.WriteLine("\n Cálculo da média harmônica das notas de um Aluno.");

            Notas notasAluno = new Notas();

            Console.Write("\n Digite a quantidade de notas: ");
            notasAluno.qtdDeNotas = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= notasAluno.qtdDeNotas; i++)
            {
                Console.Write("\n Digite a nota {0}: ", i);
                notasAluno.nota = Convert.ToDecimal(Console.ReadLine());

                notasAluno.somaInversaDasNotas += 1 / notasAluno.nota;
            }

            Console.WriteLine("\n A média harmônica é: {0:F2} ", notasAluno.CalcularMediaHarmonicaNotas());
        }
    }
}