using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio04
{
    internal class ConsumoCombustivelPorKm
    {
        public double kmFinal, kmInicial, qtdCombustivel;

        public double CalcularConsumo()
        {
            return qtdCombustivel / (kmFinal - kmInicial);
        }
    }
}
