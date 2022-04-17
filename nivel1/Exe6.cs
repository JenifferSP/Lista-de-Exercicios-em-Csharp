using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nivel1
{
    class Exe6
    {
        static void Main1(string[] args)
        {
            /*Ler uma temperatura em graus Celsius e apresentá-Ia convertida em graus Fahrenheit.
             * A fórmula de conversão de temperatura a ser utilizada é F = (9 * C + 160) / 5, em que a variável
             * F representa é a temperatura em graus Fahrenheit e a variável C representa é a temperatura em graus Celsius.*/

            float celsius, F;

            Console.WriteLine("Digite a temperatura em °C:");
            celsius = Convert.ToSingle(Console.ReadLine());

            F = (9 * celsius + 160) / 5;

            Console.WriteLine($"A temperatura em C° covertida para Fahrenheit é: " + F + " " + "°F");
            Console.ReadKey();


        }
    }
}
