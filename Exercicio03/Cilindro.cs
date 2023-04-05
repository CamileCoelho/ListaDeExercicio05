using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03
{
    internal class Cilindro
    {
        public decimal raio, altura, volume;

        public decimal numPI = 3.14159265358979323846m;

        public decimal CalcularVolume()
        {
            return numPI * (raio * raio) * altura;
        }
    }
}
