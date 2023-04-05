using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio10
{
    internal class Notass
    {
        public decimal primeiraNota, segundaNota, mediaPonderada, pesoPrimeiraNota, pesoSegundaNota;

        public decimal CalCularMediaPonderada()
        {
            return ((primeiraNota * pesoPrimeiraNota) + (segundaNota * pesoSegundaNota)) / (pesoPrimeiraNota + pesoSegundaNota);
        }
    }
}
