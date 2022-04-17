using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nivel4
{
	class Exe39
	{
		static void Main1(string[] args)
		{

			/* Faça um programa que leia um número inteiro e mostre uma mensagem
			/// indicando se este número é par ou ímpar, e se é positivo ou negativo. O
			/// programa só deve parar de rodar quando o usuário responder "S" na seguinte
			/// pergunta, "Deseja encerrar o programa?"*/


			int num;
			bool Encerrou = false;
			char escolha;

			do
			{
				Console.Write("Digite um valor: ");
				num = Convert.ToInt32(Console.ReadLine());


				if (num % 2 == 0)
				{
					Console.WriteLine("O número é par");
				}
				else
				{
					Console.WriteLine("O número impar");
				}

				if (num < 0)
				{
					Console.WriteLine("O número é negativo");
				}
				else
				{
					Console.WriteLine("O número é positivo");
				}

				Console.WriteLine();
				Console.WriteLine("Deseja sair? (s/n)? ");
				escolha = Convert.ToChar(Console.ReadLine());
				if (escolha == 's' || escolha == 'S')
				{
					Encerrou = true;
				}

			} while (Encerrou == false);


		}
	}
}

