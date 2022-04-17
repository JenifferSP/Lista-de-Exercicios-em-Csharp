using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nivel1
{
    class Exe4
    {
        static void Main1(string[] args)
        {/*Ler quatro valores numéricos inteiros e apresentar o resultado dois a dois da adição
             *  e multiplicação entre os valores lidos, baseando-se na utilização do conceito de 
             *  propriedade distributiva. Dica: se forem lidas as variáveis A, B, C e D, devem ser 
             *  somados e multiplicados os valores de A com B, A com C e A com D; depois B com C, B 
             *  com D e por último  C  com  D.  Note  que  para  cada  operação  serão  utilizadas  
             *  seis  combinações.  Assim  sendo,  devem  ser realizadas doze operações de processamento, 
             *  sendo seis para as */

            int numA, numB, numC, numD;

            //entrada dos valores
            Console.WriteLine("Insira o valor para A:");
            numA = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insira o valor para B:");
            numB = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insira o valor para C:");
            numC = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insira o valor para D:");
            numD = Convert.ToInt32(Console.ReadLine());

            //soma dos valores informados
            Console.WriteLine("A soma dos valores é:");
            Console.WriteLine($"A + B= {numA + numB}");
            Console.WriteLine($"A + C= {numA + numC}");
            Console.WriteLine($"A + D= {numA + numD}");

            Console.WriteLine($"B + C= {numB + numC}");
            Console.WriteLine($"B + D= {numB + numD}");
            Console.WriteLine($"C + D= {numC + numD}");

            //multiplicaçao dos valores
            Console.WriteLine("A multiplicação dos valores é:");
            Console.WriteLine($"A X B= {numA * numB}");
            Console.WriteLine($"A X C= {numA * numC}");
            Console.WriteLine($"A X D= {numA * numD}");

            Console.WriteLine($"B X C= {numB * numC}");
            Console.WriteLine($"B X D= {numB * numD}");
            Console.WriteLine($"C X D= {numC * numD}");

            Console.ReadKey();

        }
    }
}
