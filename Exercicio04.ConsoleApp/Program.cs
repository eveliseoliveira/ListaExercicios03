using System;

namespace Exercicio04.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tabuada\n");

            int valor_variavel = 0, resultado_operacao = 0;

                Console.WriteLine("Insira um número:");
                valor_variavel = int.Parse(Console.ReadLine());

            for (int i = 0; i <= 10; i++)
            {
                resultado_operacao = valor_variavel * i;
                Console.WriteLine(i + " * " + valor_variavel + " = " + resultado_operacao);
            }
            Console.ReadLine();
        }
    }
}
