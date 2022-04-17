using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nivel5
{
	class Exe54
	{
		static void Main1(string[] args)
		{

			/* Dado dois vetores, A (5 elementos) e B (8 elementos), faça um programa em
			* C que imprima todos os elementos comuns aos dois vetores.*/


			int[] A = new int[5], B = new int[8];
			IList<int> C = new List<int>();
			int w = 0, aux=1;

			for (int x = 0; x < 5; x++)
			{
				Console.Write($"Digite um {aux++}º número para o vetor A: ");
				A[x] = Convert.ToInt32(Console.ReadLine());
				
			}
			Console.WriteLine();
			for (int x = 0; x < 8; x++)
			{
				Console.Write($"Digite um {aux++}º número para o vetor B: ");
				B[x] = Convert.ToInt32(Console.ReadLine());
				for (int y = 0; y < 5; y++)
				{
					if (B[x] == A[y])
					{
						C.Insert(w, B[x]);
						w++;
					}
				}
			}
			Console.Write("Números comuns: ");
			for (int x = 0; x < C.Count; x++)
			{

				Console.Write(C[x] + " ");
			}
			Console.WriteLine();


		}
	}
}
