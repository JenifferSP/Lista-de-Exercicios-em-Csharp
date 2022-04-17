using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nivel5
{
	class Exe51
	{
		static void Main1(string[] args)
		{
			/*Fazer um programa para ler uma quantidade N de alunos. Ler uma nota de cada
				* um dos N alunos e calcular a média aritmética das notas. Contar quantos alunos
				* estão com nota acima de 7.0. Obs.: Se nenhum aluno tirou nota acima de 5.0,
				* imprimir mensagem: Não há nenhum aluno com nota acima de 5.*/

			int QtdAlunos, NotasP = 0; 
			bool NotasR = true; 

			Console.Write("Digite a quantidade de alunos: ");
			QtdAlunos = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine();
			Console.WriteLine();

			int[] notas = new int[QtdAlunos];

			for (int x = 0; x < QtdAlunos; x++)
			{
				Console.WriteLine($"Digite a nota do {x + 1}° Aluno: ");
				notas[x] = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine();

				if (notas[x] > 7)
				{
					NotasP++;
				}
				if (notas[x] > 5)
				{
					NotasR = false;
				}
			}

			if (NotasR == false)
			{
				Console.WriteLine($"Existem {NotasP} notas maiores que 7.");
			}
			else
			{
				Console.WriteLine("Não existe nenhum aluno com nota acima de 5.");
			}

		}
	}
}
