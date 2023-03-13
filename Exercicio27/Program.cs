
/* 27. Escreva um programa que imprima a Fibonacci. */

namespace Exercicio27
{
    public class Program
    {
        public static void Main()
        {
            Console.Clear();
            Console.WriteLine("--- Sequência Fibonacci ---\n\n");

            int atual = 0;
            int proximo = 1;
            int anterior = 0;
            string resultado = "1 ";

            for (int i = 0; i < 20; i++)
            {
                anterior = atual;
                atual = proximo;
                proximo = atual + anterior;
                resultado += proximo.ToString() + " ";
            }
            System.Console.Write(resultado);
        }
    }
}
