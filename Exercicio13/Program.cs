/* 13. A padaria Hotpão vende uma certa quantidade de pães franceses e uma quantidade de broas a cada dia. Cada
pãozinho custa R$ 0,12 e a broa custa R$ 1,50. Ao final do dia, o dono quer saber quanto arrecadou com a
venda dos pães e broas (juntos), e quanto deve guardar numa conta de poupança (10% do total arrecadado).
Você foi contratado para fazer os cálculos para o dono. Com base nestes fatos, faça um algoritmo para ler as
quantidades de pães e de broas, e depois calcular os dados solicitados. */


namespace Exercicio13
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("--- Calcular Lucros Da Padaria ---\n\n");

            Console.WriteLine($"Informe a quantidade de pãeszinhos vendidos no dia");
            int paezinhos = Int32.Parse(Console.ReadLine()!);
            decimal precoPao = 0.12M;

            Console.WriteLine($"Informe a quantidade de broas vendidas no dia");
            int broas = Int32.Parse(Console.ReadLine()!);
            decimal precoBroa = 1.50M;

            decimal valorTotalPaes = paezinhos * precoPao;
            decimal valorTotalBroas = broas * precoBroa;
            decimal porcentagem = 10M;

            decimal totalVendas = valorTotalBroas + valorTotalPaes;
            decimal valorNaPopuanca = (porcentagem / 100) * totalVendas;

            Console.Clear();
            Console.WriteLine($"O total de vendas na Data: {DateTime.Now:d}, foi de R$ {totalVendas}.\n" +
            $"O valor reservado para a poupança é de R$ {Math.Round(valorNaPopuanca, 2)}.\n"); 

        }
    }
}