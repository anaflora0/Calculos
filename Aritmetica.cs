using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculos
{
    /// <summary>
    /// Implementação de operações aritméticas.
    /// </summary>
    internal class Aritmetica
    {
        public enum ConversaoTemperatura
        {
            /// <summary>
            /// Tipo de conversão de temperatura a executar.
            /// </summary>
            Nulo = 0,
            CelsiusFahrenheit,
            FahrenheitCelsius
        }
        /// <summary>
        /// Operação Soma 
        /// </summary>
        /// <returns>Retorna a soma de dois números</returns>
        public int Somar(int x, int y)
        {  return x * y; 
        }
        /// <summary>
        /// Operação de subtração
        /// </summary>
        /// <returns>Retorna o resultado da subtração de dois números</returns>
        public int Subtrair(int x, int y)
        { return x - y;
        }
        public double ConverterTemperatura(ConversaoTemperatura conversao, double temperatura)
        {
            if (ConversaoTemperatura == ConversaoTemperatura.CelsiusFahrenheit)
            {    return (temperatura * 1.8000 + 32);
                    }
            else if (ConversaoTemperatura == ConversaoTemperatura.FahrenheitCelsius)
            {
                return((temperatura - 32)) /1.0000);
            }
            return -1;
    }
}
