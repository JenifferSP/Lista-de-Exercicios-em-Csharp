
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nivel2
{
    class Exe21
    {
        static void Main1(string[] args)
        {
            /*Faça um programa que leia um número inteiro e mostre uma mensagem na tela
             * indicando se este número é positivo ou negativo. Pare a execução do programa quando o usuário requisitar.*/
            int Num1;
            while (true)
            {
                Console.WriteLine("Digite um valor: ");
                Num1 = Convert.ToInt32(Console.ReadLine());

                if (Num1 > 0)
                {
                    Console.WriteLine($"O valor de {Num1} é positivo!");
                }
                if (Num1 <= 0)
                {
                    Console.WriteLine($"O valor de {Num1} é negativo!");
                }
                Console.WriteLine();
                Console.WriteLine($"//Deseja continua?///");
                Console.WriteLine();
                Console.WriteLine($"Digite 'SIM' para continuar ou 'NÃO' para sair: ");
                if (Console.ReadLine().Equals("NÃO")) break;
            }

        }
    }
}

