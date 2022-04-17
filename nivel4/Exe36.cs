using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nivel4
{
	class Exe36
	{
		static void Main1(string[] args)
		{

			/*Faça um programa que leia 10 valores inteiros e positivos e:
			/// - Encontre o maior valor
			/// - Encontre o menor valor
			/// - Calcule a média dos números lidos*/

			int qtd = 10;
			double media = 0;
			int[] num = new int[qtd];

			for (int x = 0; x < qtd; x++)
			{
				Console.WriteLine("Digite o " + (x + 1) + "° número: ");
				num[x] = Convert.ToInt32(Console.ReadLine());
				media += num[x];
			}
			media = media / qtd;
			Array.Sort(num); //organiza os arrays em ordem crescente

			Console.WriteLine("\nO menor número é: " + num[0]);
			Console.WriteLine("O maior número é: " + num[qtd - 1]);
			Console.WriteLine("A média dos números é: " + media);

			Console.ReadKey();
		}
	}
}

