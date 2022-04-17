
namespace nivel1
{
    class Exe1
    {
        static void Main1(string[] args)
        {
            /*
             *  Faça um programa para calcular o estoque médio de uma peça, sendo que: ESTOQUE MÉDIO = (QUANTIDADE_MÍNIMA + QUANTIDADE_MÁXIMA) / 2. 
             */

            int qtdMinima = 0;
            int qtdMax = 0;

            Console.WriteLine("Digite a quatidade minima");
            qtdMinima = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite a quatidade maxima");
            qtdMax = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"O estoque medio é: {(qtdMinima + qtdMax) / 2}");

            Console.ReadKey();

        }
    }
}
