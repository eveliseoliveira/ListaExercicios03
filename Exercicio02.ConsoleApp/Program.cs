using System;

namespace Exercicio02.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreve números ímpares entre 100 a 200\n");

            for(int i = 100; i <= 200; i++)
                if(i % 2 != 0)
                Console.WriteLine(i+"\t");

            Console.ReadLine();
        }
    }
}
