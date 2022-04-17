using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nivel1
{
    class Exe7
    {
        static void Main1(string[] args)
        {
            /*Ler uma temperatura em graus Fahrenheit e apresentá-Ia convertida em graus Celsius.
             * A fórmula de conversão de temperatura a ser utilizada é C = (F - 32) * 5 / 9, 
             * em que a variável F é a temperatura em graus Fahrenheit e a variável C é a temperatura em graus Celsius. */

            float celsius, F;

            Console.WriteLine("Digite a temperatura em °Fahrenheit:");
            F = Convert.ToSingle(Console.ReadLine());

            celsius = (F - 32) * 5 / 9;

            Console.WriteLine($"A temperatura em °Fahrenheit covertida para °Celsisus: " + celsius + " " + "°C");
            Console.ReadKey();
        }
    }
}
