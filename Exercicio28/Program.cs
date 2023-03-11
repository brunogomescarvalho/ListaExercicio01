/*28. Escreva um programa que imprima os números de 1 a 100 em ordem crescente, substituindo os números
múltiplos de 3 pela palavra Fizz; e os múltiplos de 5 pela palavra Buzz;. Para números que são múltiplos de
ambos, use FizzBuzz;*/

namespace Exercicio28
{
    public class Program
    {
        public static void Main()
        {
            Console.Clear();
            Console.WriteLine("--- Exercicio 28 ---");

            string[] sequencia = new string[100];

            for (int i = 1; i < sequencia.Length; i++)
            {
                if ((i % 3 == 0) && (i % 5 == 0))
                {
                    sequencia[i] = "FuzzBuzz";
                }

                else if (i % 3 == 0)
                {
                    sequencia[i] = "Fizz";
                }

                else if (i % 5 == 0)
                {
                    sequencia[i] = "Buzz";
                }

                else
                {
                    sequencia[i] = i.ToString();
                }

            }
            foreach (var item in sequencia)
            {
                Console.Write($"{item} - ");
            }

        }
    }

}




