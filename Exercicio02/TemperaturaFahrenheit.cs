using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02
{
    internal class TemperaturaFahrenheit
    {
        public double tempFahrenheit;

        public double ConverterTemperaturaParaCelcius()
        {
            return (tempFahrenheit - 32) * 5 / 9 ;
        }
    }
}
