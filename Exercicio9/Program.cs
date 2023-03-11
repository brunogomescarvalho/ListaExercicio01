/* 9. Crie um programa para calcular a média harmônica das notas de um Aluno*/

namespace Exercicio9;
class Program
{
    static void Main(string[] args)
    {

        Console.Clear();
        Console.WriteLine("--- Calcular Média de um Aluno ---\n");

        Console.Write("Informe a primeira nota do aluno:");
        var primeiraNota = Convert.ToDouble(Console.ReadLine());

        Console.Write("Informe a segunda nota do aluno:");
        var segundaNota = Convert.ToDouble(Console.ReadLine());

        Console.Write("Informe a terceira nota do aluno:");
        var terceiraNota = Convert.ToDouble(Console.ReadLine());

        Console.Write("Informe a quarta nota do aluno:");
        var quartaNota = Convert.ToDouble(Console.ReadLine());

        var media = ((primeiraNota) + (segundaNota) + (terceiraNota) + (terceiraNota)) / 4;

        Console.WriteLine($"O valor da Média é: {Math.Round(media, 1)}");

    }
}
