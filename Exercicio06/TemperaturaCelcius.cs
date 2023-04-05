using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio05
{
    internal class TemperaturaCelcius
    {
        public double tempCelsius;

        public double ConverterTemperaturaParaFahrenheit()
        {
            return (tempCelsius * 1.8) + 32;
        }
    }
}
