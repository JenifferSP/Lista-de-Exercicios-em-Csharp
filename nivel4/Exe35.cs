using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nivel4
{
	class Exe35
	{
		static void Main1(string[] args)
		{

			/*Faça um programa que conte de 1 até 100 e a cada múltiplo de 10 exiba uma
			/// mensagem: "Múltiplo de 10"*/

			int num;

			for (num = 1; num <= 100; num++)
			{
				if (num % 10 == 0)
				{
					Console.WriteLine($"{num}  É multiplo de 10!!");
				}
				else
				{
					Console.WriteLine(num);
				}
			}
			Console.ReadKey();
		}
	}
}

