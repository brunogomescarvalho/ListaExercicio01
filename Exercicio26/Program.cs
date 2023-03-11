namespace Exercicio26
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Digite um número para fatorar:");
            int num = int.Parse(Console.ReadLine());

            for (int i = num - 1; i > 0; i--)
            {
                num = num * i;
            }

            Console.Write(num);
        }
    }
}

