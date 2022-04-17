using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nivel5
{
	class Exe48
	{
		static void Main1(string[] args)
		{
			/*Uma agência de publicidade pediu à agência de modelos Luz & Beleza para
			* encontrar uma modelo que tenha idade entre 18 e 20 anos para participar de
			* uma campanha publicitária milionária de produtos de beleza. Foram inscritas
			* 20 candidatos e, ao se inscreverem, fornecerem nome e idade. Tais informações
			* foram definidos em 2 vetores distintos Faça um programa para imprimir o
			* vetor que contém os nomes das candidatas aptas a concorrer a uma vaga para
			* a campanha milionária.*/


			int numCandidatas = 20;
			int aptas = 0;
			string[] nome = new string[numCandidatas];
			int[] idade = new int[numCandidatas];



			for (int x = 0; x < numCandidatas; x++)
			{
				Console.WriteLine($"Digite o nome da {x + 1}ª candidata: ");
				nome[x] = Console.ReadLine();

				Console.WriteLine($"Digite a idade da {x + 1}ª candidata: ");
				idade[x] = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine();

				if (idade[x] >= 18 && idade[x] < 21)
				{
					aptas++;
				}
			}

			string[] nome_aptas = new string[aptas];
			int[] idade_aptas = new int[aptas];

			int y = 0;
			for (int x = 0; x < numCandidatas; x++)
			{
				if (idade[x] >= 18 && idade[x] < 21)
				{
					nome_aptas[y] = nome[x];
					idade_aptas[y] = idade[x];
					y++;
				}
			}

			Console.WriteLine();

			for (int x = 0; x < aptas; x++)
			{
				Console.WriteLine("///Cantidadas aptas///");
				Console.WriteLine("Nome: {0,-30} \tIdade: {1:D}\n", nome_aptas[x], idade_aptas[x]);
			}


		}
	}
}
