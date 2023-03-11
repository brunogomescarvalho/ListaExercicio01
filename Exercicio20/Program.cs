/*20. Faça um algoritmo para receber um número qualquer e informar na tela se é par ou ímpar.*/


namespace Exercicio20
{
    public class Program
    {
        public static void Main()
        {
            Console.Clear();
            Console.WriteLine("--- Verifica se o número é Par ou Ímpar ---");

            Console.WriteLine("Informe o número para verificar:");
            decimal valor = Decimal.Parse(Console.ReadLine()!);

            Console.WriteLine($"{(valor % 2 == 0 ? $"O número {valor} é par." : $"O número {valor} é ímpar.")}");

        }
    }

}