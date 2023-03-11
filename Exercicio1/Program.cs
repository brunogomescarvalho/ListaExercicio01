/*1. Crie um programa para calcular o volume de uma caixa retangular*/

namespace Exercicio1
{
    public class Program
    {
        public static void Main()
        {
            Console.Clear();
            Console.WriteLine("--- Calcular Volume de uma Caixa Retangular ---");

            Console.WriteLine("Informe o comprimento:");
            double comprimento = Double.Parse(Console.ReadLine()!);

            Console.WriteLine("Informe a largura:");
            double largura = Double.Parse(Console.ReadLine()!);

            Console.WriteLine("Informe a altura:");
            double altura = Double.Parse(Console.ReadLine()!);

            double volume = comprimento * largura * altura;

            Console.WriteLine($"O volume da caixa retangular é {volume} metros cúbicos.");

        }

    }

}

