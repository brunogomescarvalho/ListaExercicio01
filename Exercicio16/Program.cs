/* 16. Faça um algoritmo para ler o salário de um funcionário e aumentá-lo em 15%. Após o aumento, desconte 8% de
impostos. Imprima o salário inicial, o salário com o aumento e o salário final. */


namespace Exercicio16
{
    public class Program
    {
        public static void Main()
        {
            Console.Clear();
            Console.WriteLine("--- Calcular Impostos Salário Vendedor ---");

            Console.WriteLine("Informe o salário:");
            decimal salario = Decimal.Parse(Console.ReadLine()!);

            decimal aumento = 15M;
            decimal desconto = 8M;

            decimal salarioComAumento = salario + ((aumento / 100) * salario);

            decimal salarioComDesconto = salarioComAumento - ((desconto / 100) * salarioComAumento);

            Console.Clear();

            Console.WriteLine($"Valor do salário bruto: R$ {Math.Round(salario, 2)}\n");
            Console.WriteLine($"Valor do salário com aumento de {aumento}%: R$ {Math.Round(salarioComAumento, 2)}\n");
            Console.WriteLine($"Valor do salário com desconto de {desconto}%: R$ {Math.Round(salarioComDesconto, 2)}\n");

        }

    }

}

