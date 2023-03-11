/*23. Escrever um algoritmo que gera e escreve os números ímpares entre 100 e 200.*/

namespace Exercicio23
{
    public class Program
    {
        public static void Main()
        {
            Console.Clear();
            Console.WriteLine("--- Escreve números ímpares entre 100 e 200 ---");
         
            int c = 0;

            for (int i = 100; i <= 200; i++)
            {

                if (i % 2 == 1)
                {
                    Console.Write($"{i} - ");

                    //conta caracteres para pular linha
                    c++;
                    if (c % 10 == 0)
                    {
                        Console.WriteLine();
                    }
                }

            }
        }
    }

}