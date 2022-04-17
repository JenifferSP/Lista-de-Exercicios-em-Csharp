using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nivel4
{
	class Exe33
	{
		static void Main1(string[] args)
		{

			/*Escreva um programa que calcule e exiba a média da nota dos alunos de uma
			/// turma em uma prova. O número de alunos é desconhecido. Os dados de um aluno
			/// são: número de matrícula e a sua nota na prova em questão.*/

			int QtdAlunos;
			string matricula;
			double media = 0;

			Console.Write("Digite a quantidade de alunos: ");
			QtdAlunos = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine();

			int[] aluno = new int [QtdAlunos];

			for (int x = 0; x < QtdAlunos; x++)
			{
				Console.WriteLine("Digite o número da matrícula do aluno: ");
				matricula = Console.ReadLine();
				Console.WriteLine("Digite a nota do aluno: ");
				double nota = Convert.ToDouble(Console.ReadLine());
				Console.WriteLine();
				media += nota;
			}
		
			Console.WriteLine($"A média da turma foi de {string.Format("{0:C1}", (media / QtdAlunos))}");

		}
	}
}

