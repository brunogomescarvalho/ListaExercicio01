/* 18 Escreva um programa que leia tres numeros inteiros e diferentes e mostre-os em ordem decrescente*/


namespace Exercicio18
{
    public class Program
    {
        public static void Main()
        {
            Console.Clear();
            Console.WriteLine("--- Compara Valores ---");

            int[] valores = new int[3];

            Console.WriteLine("Informe o primeiro valor:");
            valores[0] = Convert.ToInt16(Console.ReadLine()!);

            Console.WriteLine("Informe o segundo valor:");
            valores[1] = Convert.ToInt16(Console.ReadLine()!);

            Console.WriteLine("Informe o terceiro valor:");
            valores[2] = Convert.ToInt16(Console.ReadLine()!);

            var valoresRepetidos = new HashSet<int>(valores);

            Console.Clear();

            if (valoresRepetidos.Count - valores.Length > 1)
            {
                System.Console.WriteLine("Não é possível inserir valores repetidos");
            }

            else
            {
                var valoresOrdenados = valores.OrderByDescending(t => t);
                string valoresOrdenadosStr = string.Join(" - ", valoresOrdenados);
                Console.WriteLine($"Valores em ordem decrescente {valoresOrdenadosStr}");
            }
            
            UsandoFor();
        }

        public static void UsandoFor()
        {
            int[] valores = new int[3];

            Console.WriteLine("Informe o primeiro valor:");
            valores[0] = Convert.ToInt16(Console.ReadLine()!);

            Console.WriteLine("Informe o segundo valor:");
            valores[1] = Convert.ToInt16(Console.ReadLine()!);

            Console.WriteLine("Informe o terceiro valor:");
            valores[2] = Convert.ToInt16(Console.ReadLine()!);

            if (valores[0] == valores[1] || valores[0] == valores[2] || valores[1] == valores[2])
            {
                Console.WriteLine("Não é possível inserir valores repetidos");
            }
            else
            {
                var maiorValor = valores[0];
                var menorValor = valores[0];
                var valorCentral = valores[0];

                //varifica maior
                for (int i = 0; i < valores.Length; i++)
                {
                    if (valores[i] > maiorValor)
                    {
                        maiorValor = valores[i];
                    }
                }

                //verifica menor
                for (int i = 0; i < valores.Length; i++)
                {
                    if (valores[i] < menorValor)
                    {
                        menorValor = valores[i];
                    }
                }

                //verifica meio
                for (int i = 0; i < valores.Length; i++)
                {
                    if (valores[i] != maiorValor && valores[i] != menorValor)
                    {
                        valorCentral = valores[i];
                    }
                }

                Console.WriteLine($"Maior valor: {maiorValor}");
                Console.WriteLine($"Menor valor: {menorValor}");
                Console.WriteLine($"Valor central: {valorCentral}");
            }

        }
    }

}

