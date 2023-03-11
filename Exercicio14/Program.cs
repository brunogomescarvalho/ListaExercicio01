/* 14. Escreva um algoritmo para ler o nome e a idade de uma pessoa, e exibir quantos dias de vida ela possui.
Considere sempre anos completos, e que um ano possui 365 dias. Ex: uma pessoa com 19 anos possui 6935 dias
de vida; veja um exemplo de saída: MARIA, VOCÊ JÁ VIVEU 6935 DIAS.*/

namespace Exercicio14
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("--- Calcular Dias de Vida---\n\n");

            Console.WriteLine($"Informe seu nome");
            string nome = Console.ReadLine()!;

            Console.WriteLine("Informe sua idade");
            int idade = Int32.Parse(Console.ReadLine()!);

            int diasDeVida = idade * 365;

            Console.Clear();
            System.Console.WriteLine($"{nome}, você já viveu {diasDeVida} dias.\n");

        }
    }
}


