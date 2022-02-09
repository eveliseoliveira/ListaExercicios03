using System;

namespace Exercicio03.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Soma números ímpares multiplos de 3 de 1 a 500\n");

            int soma_valor = 0;

            for (int i = 1; i <= 500; i++)
                if (i % 2 != 0)
                    if (i % 3 == 0)
                        soma_valor += i;

            Console.WriteLine("Resultado da soma: " + soma_valor);

            Console.ReadLine();
        }
    }
}
