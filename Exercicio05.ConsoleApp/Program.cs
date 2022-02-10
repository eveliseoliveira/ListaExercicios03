using System;

namespace Exercicio05.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fatorial\n");

            int numero_valor = 0, fatorial = 1, contador;

            Console.WriteLine("Insira um número:");
            numero_valor = int.Parse(Console.ReadLine());

            if(numero_valor != 0)
                Console.Write(numero_valor + "! = ");

            if (numero_valor <= 0)
                Console.WriteLine("Váriavel inválida!");

            else
                for (contador = numero_valor; contador >= 1; contador--)
                {
                    fatorial *= contador;
                    if (contador != 1)
                        Console.Write(contador + " x ");

                    else
                        Console.Write(contador);
                }
            if(numero_valor != 0)
                Console.Write(" = " + fatorial);

            Console.ReadLine();
        }
    }
}
