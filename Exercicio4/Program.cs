/*4. Crie um programa para calcular o consumo de combustível por Km. Deverá ser informado a quilometragem
Inicial e Final do Percurso do Veículo. Deverá ser informado o Consumo de Combustível*/

namespace Exercicio4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("--- Calcular o consumo de combustível ---");

            Console.WriteLine("\nInforme a kilometragem inicial");
            double kmInicial = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nA kilometragem final");
            double kmFinal = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nQuantidades de litros gastos na viagem");
            double totalDeLitrosConsumidos = Convert.ToDouble(Console.ReadLine());

            double kmPercorridos = kmFinal - kmInicial;
            double mediaDeConsumo = kmPercorridos / totalDeLitrosConsumidos;

            System.Console.WriteLine($"A média de consumo foi de {mediaDeConsumo} km por litro");

        }
    }

}
