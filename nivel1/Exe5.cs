using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nivel1
{
    class Exe5
    {
        static void Main1(string[] args)
        {
            /*Efetuar o cálculo da quantidade de litros de combustível gasta em uma viagem, utilizando 
                um automóvel que faz 12 Km por litro.Para obter o cálculo, o usuário deve fornecer o tempo 
                gasto na viagem e a velocidade média.Desta forma, será possível obter a distância percorrida com a
                    fórmula DISTANCIA = TEMPO * VELOCIDADE.Tendo o valor  da distância, basta calcular  a quantidade  
                    de litros  de combustível  utilizada na  viagem com  a fórmula: LITROS_USADOS = DISTANCIA / 12.O
                    programa deve apresentar os valores da velocidade média, tempo gasto, a distância percorrida e a 
                    quantidade de litros utilizada na viagem.Dica: trabalhe com valores reais. */


            double distancia, LTusado;
            float tempo;
            float vKM;

            Console.WriteLine("Olá, digite o tempo da viagem:");
            tempo = Convert.ToSingle(Console.ReadLine());


            Console.WriteLine("Agora me fale a velocidade media durante o percusso:");
            vKM = Convert.ToSingle(Console.ReadLine());

            distancia = tempo * vKM;
            LTusado = distancia / 12;

            Console.WriteLine($"Tempo de viagem:" + tempo);
            Console.WriteLine($"Velocidde media:" + vKM + "Km/h");
            Console.WriteLine($"Distancia percorrida:" + distancia + "Km");
            Console.WriteLine($"Quantidade de combustuel gasto:" + LTusado + "l");

            Console.ReadKey();

        }
    }
}
