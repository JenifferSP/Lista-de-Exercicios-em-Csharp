using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nivel1
{
    class Exe8
    {
        static void Main1(string[] args)
        {
            /*Calcular e apresentar o valor do volume de uma lata de óleo, utilizando a 
             * fórmula: V =  3.14159 * R * R * A
             * Onde as variáveis: V, R e A 
             * representam respectivamente o volume, o raio e a altura.*/
            double raio, volume, altura;

            Console.WriteLine("///Programa para calcular o volume de uma lata de Oleo///");
            Console.WriteLine("Insira o valor do raio:");
            raio = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Insira o valor do altura :");
            altura = Convert.ToDouble(Console.ReadLine());

            volume = 3.14159 * raio * raio * altura;

            Console.Write($"O volume da lata é: " + volume);
            Console.ReadKey();
        }
    }
}
