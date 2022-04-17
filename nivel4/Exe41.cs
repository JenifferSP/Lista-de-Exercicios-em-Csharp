using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nivel4
{
	class Exe41
	{
		static void Main1(string[] args)
		{

			/* Faça um programa que dada a idade de um nadador, classifique-o em uma das
			/// seguintes categorias:
			/// 	- Infantil A = 5 a 7 anos
			/// 	- Infantil B = 8 a 11 anos
			/// 	- Juvenil A = 12 a 13 anos
			/// 	- Juvenil B = 14 a 17 anos
			/// 	- Adultos = Maiores de 18 anos*/


			int idade;
			bool Encerrar = false;
			char opcao;
			string categoria;

			do
			{
				do
				{
					Console.Write("Digite a sua idade: ");
					idade = Convert.ToInt32(Console.ReadLine());

					if (idade < 5)
					{
						Console.WriteLine("Você não tem idade suficiente!");
						Console.WriteLine();
					}
				} while (idade < 5);

				Console.WriteLine();

				if (idade >= 5 && idade < 8)
				{
					categoria = "Infantil A";
				}
				else if (idade >= 8 && idade < 12)
				{
					categoria = "Infantil B";
				}
				else if (idade >= 12 && idade < 14)
				{
					categoria = "Juvenil A";
				}
				else if (idade >= 14 && idade < 18)
				{
					categoria = "Juvenil B";
				}
				else
				{
					categoria = "Adultos";
				}


				Console.WriteLine("Sua categoria é: " + categoria);

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

