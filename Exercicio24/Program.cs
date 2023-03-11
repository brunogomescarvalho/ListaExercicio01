/*24. Desenvolver um algoritmo que efetue a soma de todos os números ímpares que são múltiplos de três e que se
encontram no conjunto dos números de 1 até 500.*/

namespace Exercicio24
{
    public class Program
    {
        public static void Main()
        {
            Console.Clear();
            int soma = 0;
            for (int i = 0; i <= 500; i++)
            {
                if (i % 2 == 1 && i % 3 == 0)
                {
                    System.Console.WriteLine(i);
                    soma += i;
                }
            }
            System.Console.WriteLine($"A soma dos números ímpares múltiplos de 3 até 500 é: {soma}");

        }
    }
}