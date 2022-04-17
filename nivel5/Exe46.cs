using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nivel5
{
	class Exe46
	{
		static void Main1(string[] args)
		{
			/*Dados dois vetores xey, ambos com n elementos, determinar o produto escalar dessas
			* vetores. Ou seja, realizar a soma de todos os resultados da multiplicação de x[i] por y[i].*/

			int quantidade;

			Console.Write("Quantos numeros deseja inserir?: ");
			quantidade = Convert.ToInt32(Console.ReadLine());

			int[] vetorX = new int[quantidade];
			int[] vetorY = new int[quantidade];

			for (int x = 0; x < quantidade; x++)
			{
				Console.WriteLine($"Digite o {x + 1}° Número para o vetor X: ");
				vetorX[x] = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine();
			}
			for (int y = 0; y < quantidade; y++)
			{
				Console.WriteLine($"Digite o {y + 1}° Número para o vetor Y: ");
				vetorY[y] = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine();
			}

			Console.Write("A multiplicação dos vetores é:\n");
			for (int w = 0; w < quantidade; w++)
			{
				Console.WriteLine($"{vetorX[w]} X {vetorY[w]} = {(vetorY[w] * vetorX[w])}");
			}



		}
	}
}
