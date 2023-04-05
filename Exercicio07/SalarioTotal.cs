using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio07
{
    internal class SalarioTotal
    {
        public decimal salarioBase, totalVendas, comissao;

        public decimal CalcularSalarioTotal()
        {
            return salarioBase + (totalVendas * comissao);
        }
    }
}
