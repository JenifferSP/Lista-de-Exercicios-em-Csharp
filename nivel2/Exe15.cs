
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nivel2
{
    class Exe15
    {
        static void Main1(string[] args)
        {
            /*Escreva um programa que leia quatro notas escolares de um aluno e apresentar uma mensagem
             * que o aluno foi aprovado se o valor da média escolar for maior ou igual a 7. Se o valor da
             * média for menor que 7, solicitar a nota do recuperação, somar com o valor da média e obter
             * a nova média. Se a nova média for maior ou igual a 7, apresentar uma mensagem informando que
             * o aluno foi aprovado na recuperação. Se o aluno não foi aprovado, apresentar uma mensagem informando
             * esta condição. Apresentar junto com as mensagens o valor da média do aluno. */

            float nota1, nota2, nota3, nota4, media, mediaN, notaN;

            Console.WriteLine("Bem vindo! Insira a primeira nota: ");
            nota1 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Bem vindo! Insira a segunda nota: ");
            nota2 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Bem vindo! Insira a terceira nota: ");
            nota3 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Bem vindo! Insira a quarta nota: ");
            nota4 = Convert.ToSingle(Console.ReadLine());

            media = (nota1 + nota2 + nota3 + nota4) / 4;

            if (media >= 7)
            {
                Console.WriteLine("Parabens! Aluno aprovado!! Nota Final: " + media);
            }
            else
            {
                Console.WriteLine("Aluno em recuperação!! Nota Final: " + media);
                Console.WriteLine("Insira a nota da recuperação: ");
                notaN = Convert.ToSingle(Console.ReadLine());

                mediaN = media + notaN;

                if (mediaN >= 7)
                {
                    Console.WriteLine("Parabens! Aluno aprovado na recuperação!! Nota Final: " + mediaN);
                }
                else
                {
                    Console.WriteLine("Aluno reprovado!");
                }
                Console.ReadKey();

            }
        }
    }
}
