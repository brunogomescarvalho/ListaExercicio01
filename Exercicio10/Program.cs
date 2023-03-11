/*10. Crie um programa para calcular a média ponderada de duas provas realizadas por um aluno*/
namespace Exercicio10;
class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("--- Calcular média ponderada de duas provas ---\n");

        Console.WriteLine("Informe a primeira nota do aluno:");
        var nota1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Informe o Peso da primeira prova.");
        var peso1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Informe a segunda nota do aluno:");
        var nota2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Informe o Peso da segunda prova.");
        var peso2 = Convert.ToDouble(Console.ReadLine());

        var media = (nota1 * peso1 + nota2 * peso2) / (peso1 + peso2);

        Console.WriteLine($"O valor da Média é: {Math.Round(media, 1)}");


    }

}
