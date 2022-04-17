using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nivel5
{
	class Exe45
	{
		static void Main1(string[] args)
		{
			/*Dada uma seqüência de n números (vetor de inteiros), imprimi-la na ordem inversa que
			* foi realizada a leitura.*/

			int qtd;

			Console.WriteLine("Quantos numeros deseja digitar?: ");
			qtd = Convert.ToInt32(Console.ReadLine());

			int[] Num = new int[qtd];

			for (int x = 0; x < qtd; x++)
			{
				Console.WriteLine($"Digite o {x + 1}° Número: ");
				Num[x] = Convert.ToInt32(Console.ReadLine());
			}
			Console.WriteLine("\nA ordem contrária é:\n");
			for (int y = qtd - 1; y >= 0; y--)
			{
				Console.WriteLine(Num[y]);
			}

		}
	}
}
