/*11. Crie um programa para verificar se um número é primo.*/

namespace Exercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continuar = true;
            do
            {
                Console.Clear();
                Console.WriteLine("--- Verificar se número é um Número Primo ---\n\n");

                Console.Write("Informe o número: ");
                int numero = Convert.ToInt16(Console.ReadLine());

                if (numero < 2)
                {
                    Console.WriteLine("0 e 1 não são primos.\n");
                }

                else if (numero == 2 || numero == 3)
                {
                    Console.WriteLine($"O número {numero} é primo.\n");
                }

                else
                {
                    bool numeroPrimo = true;

                    for (int i = 2; i < numero; i++)
                    {
                        if (numero % i == 0)
                        {
                            numeroPrimo = false;
                            break;
                        }
                    }

                    if (numeroPrimo)
                    {
                        Console.WriteLine($"O número {numero} é primo.\n");
                    }

                    else
                    {
                        Console.WriteLine($"O número {numero} não é primo.\n");
                    }
                }

                System.Console.WriteLine("Gostaria de continuar? [s/n]");
                var opcao = Console.ReadLine();

                if (opcao == "n".ToLower())
                {
                    continuar = false;
                }

            } while (continuar);
        }
    }
}
