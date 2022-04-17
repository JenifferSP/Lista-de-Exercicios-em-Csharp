using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nivel1
{
    class Exe9
    {
        static void Main1(string[] args)
        {
            /*Faça um algoritmo que leia a idade de uma pessoa expressa em anos, 
              * meses e dias e escreva a idade dessa pessoa expressa apenas em dias. 
              * Considerar ano com 365 dias e mês com 30 dias. */
            int idadeAnos, IdadeMeses, IdadeDias, IdadeDiasTd;

            Console.WriteLine("Escreva sua idade (total em anos):");
            idadeAnos = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Escreva sua idade (total em meses):");
            IdadeMeses = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Escreva sua idade (total em dias):");
            IdadeDias = Convert.ToInt16(Console.ReadLine());

            IdadeDiasTd = (IdadeDias + (idadeAnos * 365) + (IdadeMeses * 30));

            Console.WriteLine($"Sua idade expressada em dias é: " + IdadeDiasTd + " Dias");
            Console.ReadKey();

        }
    }
}
