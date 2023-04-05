using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio05
{
    internal class Esfera
    {
        public double raio;

        public double CalcularVolume()
        {
            return (4.0 / 3.0) * Math.PI * (raio * raio * raio) ;
        }
    }
}
