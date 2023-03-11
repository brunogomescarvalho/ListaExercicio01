/*21. Faça um algoritmo que leia dois valores inteiros A e B, se os valores forem iguais deverá se somar os dois, caso
contrário multiplique A por B.*/

namespace Exercicio21
{
    public class Program
    {
        public static void Main()
        {
            Console.Clear();
            Console.WriteLine("--- Calcula números ---");

            Console.WriteLine("Informe o primeiro valor:");
            int primeiroValor = int.Parse(Console.ReadLine()!);

            Console.WriteLine("Informe o segundo valor:");
            int segundoValor = int.Parse(Console.ReadLine()!);

            int resultado = (primeiroValor == segundoValor) ? (primeiroValor + segundoValor) : (primeiroValor * segundoValor);
            string operacao = (primeiroValor == segundoValor) ? " + " : " x ";

            Console.WriteLine($"{primeiroValor} {operacao} {segundoValor} = {resultado}\n");
        }
    }

}