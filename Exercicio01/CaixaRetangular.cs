using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeExercicios05.Exercicio01
{
    internal class CaixaRetangular
    {
        public decimal largura;
        public decimal altura;
        public decimal comprimento;

        public decimal CalcularVolume()
        {
            return altura * largura * comprimento;
        }

    }
}
