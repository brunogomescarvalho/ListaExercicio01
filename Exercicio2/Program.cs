/*2. Crie um programa para converter a temperatura de graus Fahrenheit para graus Celsius*/
namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Clear();
            Console.WriteLine("--- Converter Fahrenheit para Celsius ---");

            Console.WriteLine("Informe a temperatura em fahrenheit:");
            double fahrenheit = Convert.ToDouble(Console.ReadLine()!);

            double celsius = ((fahrenheit - 32) / 1.8);

            Console.WriteLine($"A temperatura está em {celsius} graus Celsius.");
        }
    }
}