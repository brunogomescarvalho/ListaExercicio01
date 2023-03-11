/*6. Crie um programa para converter a temperatura da escala Celsius para a escala Fahrenheit*/

namespace Exercicio6
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