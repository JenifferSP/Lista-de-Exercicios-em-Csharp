
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel3
{
    class Exe24
    {
        static void Main1(string[] args)
        {

            /* Escreva um programa que leia dois números inteiros e apresente as opções para usuário escolher
             * o que deseja realizar:
             * 1 – Verificar se um dos números lidos é ou não múltiplo do outro 
             * 2 – Verificar se os dois números lidos são pares 
             * 3 – Verificar se a média dos dois números é maior ou igual a 7. 
             * 4 – Sair  */

            int num1, num2;
            int opcao = 0;
            while (true)
            {
                Console.WriteLine("Insira um valor: ");
                num1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Insira um segundo valor: ");
                num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("O que deseja fazer? ");
                Console.WriteLine();
                Console.WriteLine("1 – Verificar se um dos números lidos é ou não múltiplo do outro");
                Console.WriteLine("2 – Verificar se os dois números lidos são pares");
                Console.WriteLine("3 – Verificar se a média dos dois números é maior ou igual a 7.");
                Console.WriteLine("4 – Sair");
                opcao = Convert.ToInt32(Console.ReadLine());

                if (opcao == 1)
                {
                    if (num1 % num2 == 0 || num2 % num1 == 0)
                    {
                        Console.WriteLine("Os numeros insiridos são multiplos!");
                    }
                    else
                    {
                        Console.WriteLine("Os numeros insiridos não são multiplos!");
                    }
                }
                if (opcao == 2)
                {
                    if (num1 % 2 == 0 && num2 % 2 == 0)
                    {
                        Console.WriteLine("Ambos numeros são pares!");
                    }
                    else
                    {
                        Console.WriteLine("Os dois numero não são pares!");
                    }
                }
                if (opcao == 3)
                {
                    if ((num1 + num2) / 2 > 7)
                    {
                        ;
                        Console.WriteLine("A media dos numeros é maior que 7!");
                    }
                    else
                    {
                        Console.WriteLine("A media dos numeros é menor que 7!");
                    }

                }

                if (opcao == 4) break;


            }
        }
    }
}

