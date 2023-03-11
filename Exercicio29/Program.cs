namespace Exercicio29
{
    public class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("--- Tabuada de Multiplicação de 1 até 10 ---\n");
            Console.Clear();

            int cursor = 1;

            for (int i = 1; i <= 10; i++)
            {
                Console.CursorTop = 0;

                for (int j = 1; j <= 10; j++)
                {
                    Console.CursorLeft = cursor;
                    System.Console.WriteLine($"{i} x {j} = {i * j}");
                }

                cursor += 15;
            }
        }
    }
}