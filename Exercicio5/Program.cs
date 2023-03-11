/*5. Crie um programa para calcular o volume de uma esfera*/

namespace Exercicio5
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Console.Clear();

            Console.WriteLine("--- Calcular o volume de uma esfera ---");

            Console.WriteLine("Informe a medida do raio da esfera");

            double raio = Convert.ToDouble(Console.ReadLine());

            const double pi = 3.1415;

            System.Console.WriteLine(raio);

            double volume = (4 / 3) * pi * (raio * raio * raio);

            Console.WriteLine($"O volume da esfera é de: {Math.Round(volume, 2)}");
        }
    }

}




