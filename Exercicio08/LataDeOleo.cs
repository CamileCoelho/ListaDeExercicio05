using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio08
{
    internal class LataDeOleo
    {
        public decimal raio, altura, numPI = 3.14159265358979323846m;

        public decimal CalcularVolume()
        {
            return numPI* (raio*raio) * altura;
        }

    }
}
