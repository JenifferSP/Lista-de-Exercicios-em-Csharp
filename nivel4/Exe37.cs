using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nivel4
{
	class Exe37
	{
		static void Main1(string[] args)
		{

			/*Faça um programa de conversão de base numérica. O programa deverá
			/// apresentar uma tela de entrada com as seguintes opções:
			///		1 – Adição
			///		2 – Subtração
			///		3 – Multiplicação
			///		4 – Divisão
			/// Informe a opção:
			/// A partir da opção escolhida, o programa deverá solicitar para que o usuário
			/// digite dois números. Em seguida, o programa deve exibir o resultado da opção
			/// indicada pelo usuário e perguntar ao usuário se ele deseja voltar ao menu
			/// principal. Caso a resposta seja  ́S ́ ou  ́s ́, deverá voltar ao menu, caso
			/// contrário deverá encerrar o programa.*/

			int opcao;
			string charOpcao;
			bool encerrar = false;
			int num1=0, num2=0;

			while (encerrar == false)
			{

				Console.WriteLine("Escolha uma das opções abaixo: ");
				Console.WriteLine("1 – Adição");
				Console.WriteLine("2 – Subtração");
				Console.WriteLine("3 – Multiplicação");
				Console.WriteLine("4 – Divisão");
				
				opcao = Convert.ToInt32(Console.ReadLine());

				Console.WriteLine("Digite o primeiro valor: ");
				num1 = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("Digite o segundo valor: ");
				num2 = Convert.ToInt32(Console.ReadLine());


				switch (opcao)
				{
					case 1:					
						Console.WriteLine($"Resultado de {num1} + {num2} = {num1 + num2}");
						break;

					case 2:
						Console.WriteLine($"Resultado de {num1} - {num2} = {num1 - num2}");
						break;

					case 3:
						Console.WriteLine($"Resultado de {num1} X {num2} = {num1 * num2}");
						break;

					case 4:
						Console.WriteLine($"Resultado de {num1} / {num2} = {num1 / num2}");
						break;

					default:
						Console.WriteLine("Opção inválida, digite novamente a opção: ");
						opcao = Convert.ToInt32(Console.ReadLine());
						break;
				}
				Console.WriteLine("Deseja continuar?(s/n)");
				charOpcao = Console.ReadLine();
				if (string.ReferenceEquals(charOpcao, "N") || string.ReferenceEquals(charOpcao, "n"))
				{
					encerrar = true;
				}
			}



		}
	}
}

