
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nivel3
{
    class Exe23
    {
        static void Main1(string[] args)
        {

            /* Escreva um programa que exiba as seguintes opções e realize os que se pede em cada uma delas:
             * 1 – Adição
             * 2 – Subtração 
             * 3 – Multiplicação
             * 4 – Divisão */
            float num1, num2, Nresult;
            int opcao;
            while (true)
            {
                Console.WriteLine("Insira um valor: ");
                num1 = Convert.ToSingle(Console.ReadLine());

                Console.WriteLine("Insira um sugundo valor: ");
                num2 = Convert.ToSingle(Console.ReadLine());

                Console.WriteLine();
                Console.WriteLine("///Escolha uma operação: ");
                Console.WriteLine();
                Console.WriteLine("[1]para Adição");
                Console.WriteLine("[2] para Subtração");
                Console.WriteLine("[3] para Multiplicação");
                Console.WriteLine("[4] para Divisão");
                Console.WriteLine();
                opcao = Convert.ToInt16(Console.ReadLine());

                if (opcao == 1)
                {
                    Nresult = num1 + num2;
                    Console.WriteLine($"O resultado é: " + Nresult);
                }
                if (opcao == 2)
                {
                    Nresult = num1 - num2;
                    Console.WriteLine($"O resultado é: " + Nresult);
                }
                if (opcao == 3)
                {
                    Nresult = num1 * num2;
                    Console.WriteLine($"O resultado é: " + Nresult);
                }
                if (opcao == 4)
                {
                    Nresult = num1 / num2;
                    Console.WriteLine($"O resultado é: " + Nresult);
                }


                Console.WriteLine();
                Console.WriteLine("Digite S para sair ou qualquer coisa para continuar");
                if (Console.ReadLine().Equals("S")) break;

            }
        }
    }
}

