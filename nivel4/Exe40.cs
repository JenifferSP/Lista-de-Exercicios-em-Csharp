using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nivel4
{
	class Exe40
	{
		static void Main1(string[] args)
		{

			/* A Secretaria de Meio Ambiente que controla o índice de poluição mantém 03
			/// grupos de indústrias que são altamente poluentes do meio ambiente. O índice
			/// de poluição aceitável varia de 0,05 até 0,25. Se o índice sobe para 0,3 as
			/// indústrias do 1o grupo são intimadas a suspenderem suas atividades, se o
			/// índice crescer para 0,4 as industrias do 1o e 2o grupo são intimadas a
			/// suspenderem suas atividades, se o índice atingir 0,5 todos os grupos devem ser
			/// notificados a paralisarem suas atividades. Faça um programa que leia o índice
			/// de poluição medido e emita a notificação adequada aos diferentes grupos de
			/// empresas. O algoritmo só deve parar de rodar quando o usuário responder "S" na
			/// seguinte pergunta, "Deseja encerrar o programa?"*/


			double num;
			bool Encerrar = false;
			char opcao;

			do
			{
				do
				{
					Console.WriteLine("Digite o índice de poluição (Utilize ',' Exe: 0,1): ");
					num = Convert.ToDouble(Console.ReadLine());

					if (num < 0)
					{
						Console.WriteLine("Número inválido!");
					}
				} while (num < 0);

				Console.WriteLine();

				if (num >= 0 && num <= 0.25)
				{
					Console.WriteLine("Índice de poluição aceitável.");
				}


				if (num >= 0.3)
				{
					Console.WriteLine("Suspender as atividades das indústrias do Grupo 1!");
				}

				if (num >= 0.4)
				{
					Console.WriteLine("Suspender as atividades das indústrias do Grupo 2!");
				}

				if (num >= 0.5)
				{
					Console.WriteLine("Suspender as atividades das indústrias do grupo 3!");
				}

				Console.WriteLine("\nDeseja encerrar o programa? (s/n) ");
				opcao = Convert.ToChar(Console.ReadLine());

				if (opcao == 's' || opcao == 'S')
				{
					Encerrar = true;
				}

			} while (Encerrar == false);

		}
	}
}

