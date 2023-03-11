/*7. Crie um programa para calcular o salário total de um vendedor. Deverá ser informado o salário base e o total de
vendas. A comissão é calculada com um percentual (informado pelo usuário) sobre o total de vendas.*/

namespace Exercicio7;
public class Program
{
    public static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("--- Calcular Salário De Um Vendendor ---\n");

        Console.Write("Informe o valor do Salário Base: ");
        decimal salarioFixo = Convert.ToDecimal(Console.ReadLine()!);
        Console.WriteLine();

        Console.Write("Informe o valor Total Das Vendas: ");
        decimal totalVendas = Convert.ToDecimal(Console.ReadLine()!);
        Console.WriteLine();

        Console.Write("Informe o valor do Percentual Ganho: ");
        decimal percentualGanho = Convert.ToDecimal(Console.ReadLine()!);
        Console.WriteLine();

        decimal salarioTotal = (salarioFixo + (totalVendas * (percentualGanho / 100)));
        Console.WriteLine($"Salário Total de R$ {salarioTotal}.");

    }
}