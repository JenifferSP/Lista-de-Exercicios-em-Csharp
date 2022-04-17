
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nivel2
{
    class Exe14
    {
        static void Main1(string[] args)
        {
            /*escreva um programa de leia dois numeros e apresente a diferença do maior para o menor*/

            int num1, num2;

            Console.WriteLine("Insira o 1° valor: ");
            num1 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Insira o 2° valor: ");
            num2 = Convert.ToInt16(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine($"A diferença entre os valores insiridos é: {num1 - num2}");
            }
            else
            {
                Console.WriteLine($"A diferença entre os valores insiridos é: {num2 - num1}");
            }

            Console.ReadKey();
        }
    }
}
