using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nivel2
{
    class Exe11
    {
        static void Main1(string[] args)
        {
            /*Ler dois valores inteiros para as variáveis A e B, efetuar a troca dos valores de modo que
             * a variável A passe a possuir o valor da variável B, e a variável B passe a possuir o valor
             * da variável A. Apresentar os valores trocados.*/

            int A, B, aux;

            Console.WriteLine("Insira um valor para A: ");
            A = Convert.ToInt16(Console.ReadLine());


            Console.WriteLine("Insira um valor para B: ");
            B = Convert.ToInt16(Console.ReadLine());

            aux = A;
            A = B;
            B = aux;

            Console.WriteLine("A :" + A);
            Console.WriteLine("B :" + B);

            Console.ReadKey();
        }
    }
}
