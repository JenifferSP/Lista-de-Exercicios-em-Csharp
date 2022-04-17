using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nivel5
{
	class Exe53
	{
		static void Main1(string[] args)
		{

			/* Durante uma corrida de automóveis com N voltas de duração foram anotados
			 * para um piloto, na ordem, os tempos registrados em cada volta. Fazer um
			* programa para ler das N voltas, calcular os tempos e imprimir:
			* i. melhor tempo;
			* ii. a volta em que o melhor tempo ocorreu;
			*iii. tempo médio das N voltas;.*/


			int NVoltas, total = 0, media, MTempo = 0, MVolta = 0;

			Console.WriteLine("Digite o número de voltas: ");
			NVoltas = Convert.ToInt32(Console.ReadLine());

			int[] tempos = new int[NVoltas];
			for (int x = 0; x < NVoltas; x++)
			{
				Console.WriteLine($"Digite o tempo da {x + 1}ª volta (em segundos): ");
				tempos[x] = Convert.ToInt32(Console.ReadLine());
				total += tempos[x];
				if (tempos[x] < MTempo || x == 0)
				{
					MTempo = tempos[x];
					MVolta = x + 1;
				}
			}
			media = total / NVoltas;


			Console.WriteLine($"i.   O melhor tempo foi: {MTempo} segundos.");
			Console.WriteLine($"ii.  Melhor volta foi: {MVolta}ª");
			Console.WriteLine($"iii. A média de tempo foi: {media}");


		}
	}
}
