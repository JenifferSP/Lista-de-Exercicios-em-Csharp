using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nivel4
{
	class Exe43
	{
		static void Main1(string[] args)
		{

			/*Uma rainha requisitou os serviços de um monge e disse-lhe que pagaria
			/// qualquer preço. O monge, necessitando de alimentos, indagou à rainha sobre o
			/// pagamento, se poderia ser feito com grãos de trigo dispostos em um tabuleiro
			/// de xadrez, de tal forma que o primeiro quadro deveria conter apenas um grão e
			/// os quadros subseqüentes, o dobro do quadro anterior. A rainha achou o trabalho
			/// barato e pediu que o serviço fosse executado, sem se dar conta de que seria
			/// impossível efetuar o pagamento. Faça um programa para calcular o número de
			/// grãos que o monge esperava receber.*/

			double graosCasa = 1, casasTabuleiro = 64;
			int graos = 1;

			for (int x = 1; x < casasTabuleiro; x++)
			{
				graosCasa = graosCasa * 2;
				graos += (int)graosCasa;
			}

			Console.WriteLine("\nO quantidade de grãos é: " + graos);

		}
	}
}

