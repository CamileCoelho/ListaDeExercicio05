using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio09
{
    internal class Notas
    {
        public int qtdDeNotas;

        public decimal nota, somaInversaDasNotas = 0;

        public decimal CalcularMediaHarmonicaNotas()
        {
            return qtdDeNotas / somaInversaDasNotas;
        }
    }
}
