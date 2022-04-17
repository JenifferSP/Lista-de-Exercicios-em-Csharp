
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nivel2
{
    class Exe19
    {
        static void Main1(string[] args)
        {
            /*Escreva um programa que leia três valores para os lados de um triângulo (variáveis A, B e C).
             * Verificar se cada lado é menor que a soma dos outros dois lados. Se sim, saber de A==B e se B==C,
             * sendo verdade o triângulo é eqüilátero; Se não, verificar de A==B ou se A==C ou se B==C, sendo verdade
             * o triângulo é isósceles; e caso contrário, o triângulo será escaleno. Caso os lados fornecidos não caracterizarem
             * um triângulo, avisar  a ocorrência.*/

            int ladoA, ladoB, ladoC;

            Console.WriteLine("Inrira um valor para o lado A");
            ladoA = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Inrira um valor para o lado B");
            ladoB = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Inrira um valor para o lado C");
            ladoC = Convert.ToInt16(Console.ReadLine());


            if (ladoA < ladoB + ladoC && ladoB < ladoA + ladoC && ladoC < ladoA + ladoB)
            {
                if (ladoA == ladoB && ladoB == ladoC)
                {
                    Console.WriteLine("Esse é um triângulo eqüilátero!");

                }

                else if (ladoA == ladoB || ladoA == ladoC || ladoB == ladoC)
                {
                    Console.WriteLine("Esse é um triângulo isósceles!");

                }

                else
                {
                    Console.WriteLine("Esse é um triângulo escaleno!");
                }
            }
            else
            {
                Console.WriteLine("Os dados inseridos não se caracterizam com um triangulo");
            }
        }
    }
}

