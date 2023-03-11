/*17. Faça um algoritmo que leia os valores A, B, C e imprima na tela se a soma de A + B é menor que C.*/


namespace Exercicio17
{
    public class Program
    {
        public static void Main()
        {
            Console.Clear();
            Console.WriteLine("--- Comparar Valores ---");

            Console.WriteLine("Informe o valor de A:");
            decimal valor_a = Decimal.Parse(Console.ReadLine()!);

            Console.WriteLine("Informe o valor de B:");
            decimal valor_b = Decimal.Parse(Console.ReadLine()!);

            Console.WriteLine("Informe o valor de C:");
            decimal valor_c = Decimal.Parse(Console.ReadLine()!);

            bool ehMaior = (valor_a + valor_b) > valor_c;

            string resultado = ehMaior ? "A soma de A e B é maior que C" : "A soma de A e B é menor que C";

            Console.WriteLine(resultado);

        }

    }

}

