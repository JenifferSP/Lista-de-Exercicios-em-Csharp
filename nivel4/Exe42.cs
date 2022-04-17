using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nivel4
{
	class Exe42
	{
		static void Main1(string[] args)
		{

			/*Faça um programa que determine o maior e o menor entre N números lidos.
			/// A condição de parada é a entrada de um valor 0, ou seja, o programa deve ficar
			/// executando até que a entrada seja igual a 0 (ZERO).*/

			int numero, maior, menor;
			Console.WriteLine("///Digite 0 para sair////");
			Console.WriteLine();
			Console.WriteLine();

			Console.Write("Digite um número: ");
			numero = Convert.ToInt32(Console.ReadLine());
			menor = numero;
			maior = numero;

			do
			{
				Console.Write("Digite um número: ");
				numero = Convert.ToInt32(Console.ReadLine());

				if (numero > maior)
				{
					maior = numero;
				}
				if (numero < menor && numero != 0)
				{
					menor = numero;
				}

			} while (numero != 0);

			Console.WriteLine($"\nO mmior numero digitado é {menor}   O menor número digitaado é {maior}");


		}
	}
}

