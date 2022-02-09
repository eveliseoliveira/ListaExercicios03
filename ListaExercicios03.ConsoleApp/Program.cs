using System;

namespace ListaExercicios03.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] armazena_altura = new double[15];

            double menor = 0, maior = 0, menor_posicao = 0, maior_posicao = 0;

            for (int i = 0; i < armazena_altura.Length; i++)
            {
                Console.WriteLine("Informe a altura, posição " + i + ":");
                armazena_altura[i] = Convert.ToDouble(Console.ReadLine());
            }

            for (int i = 0; i < armazena_altura.Length; i++)
            {
                if (i == 0)
                {
                    menor = armazena_altura[0];
                    maior = armazena_altura[0];
                }

                else if (armazena_altura[i] < menor)
                {
                    menor = armazena_altura[i];
                    menor_posicao = i;
                }

                else if (armazena_altura[i] > maior)
                {
                    maior = armazena_altura[i];
                    maior_posicao = i;
                }
            }

            Console.WriteLine("A menor altura é " + menor + " m, na posição " + menor_posicao);
            Console.WriteLine("A maior altura é " + maior + " m, na posição " + maior_posicao);

            Console.ReadLine();
        }
    }
}

