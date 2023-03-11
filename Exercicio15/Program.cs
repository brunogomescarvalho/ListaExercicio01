/* 15. Alguns países medem temperaturas em graus Celsius, e outros em graus Fahrenheit. Faça um algoritmo para ler
uma temperatura Celsius e imprima em Fahrenheit */

namespace Exercicio15
{
    public class Program
    {
        public static void Main()
        {
            Console.Clear();
            Console.WriteLine("--- Converter Celsius para Fahrenheit ---\n\n");

            Console.WriteLine("Informe a temperatura em celsius:");
            double celsius = Convert.ToDouble(Console.ReadLine()!);

            double fahrenheit = ((celsius * 1.8) + 32);

            Console.WriteLine($"A temperatura está em {fahrenheit} graus Fahrenheit.");
        }
    }
}
