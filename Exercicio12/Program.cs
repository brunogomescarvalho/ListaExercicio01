/*12. A imobiliária Imóbilis vende apenas terrenos retangulares. Faça um algoritmo para ler as dimensões de um
terreno e depois exibir a área do terreno.*/
namespace Exercicio12
{
    public class Program
    {
        public static void Main()
        {
            Console.Clear();
            Console.WriteLine("--- Calcular a área de um Terreno Retangular ---\n\n");

            Console.WriteLine("Informe o comprimento:");
            double comprimento = Convert.ToDouble(Console.ReadLine()!);

            Console.WriteLine("Informe a largura:");
            double largura = Convert.ToDouble(Console.ReadLine()!);

            double area = comprimento * largura;

            Console.Clear();
            Console.WriteLine($"\nA área do terreno é de {Math.Round(area, 2)} metros quadrados.\n");

        }
    }
}


