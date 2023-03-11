/*3. Crie um programa para calcular o volume de um Cilindro*/

namespace Exercicio3
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("--- Calcular volume de um Cilindro");
            const double pi = 3.1415;

            Console.WriteLine("Informe a medida do raio da base do cilindro em centimetros:");
            double raio = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe a medida da altura do cilindro em centimetros:");
            double altura = Convert.ToDouble(Console.ReadLine());

            double areaBase = (pi * Math.Pow(raio, 2));

            Console.WriteLine(areaBase);

            double volume = (areaBase * altura);

            Console.WriteLine($"O volume do cilindro é {Math.Round(volume, 2)} cm³.");

        }
    }

}