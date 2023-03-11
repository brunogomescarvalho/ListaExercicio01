/*8. Crie um programa para calcular o volume de uma lata de óleo*/
Console.WriteLine("--- Calcular volume de uma Lata de Óleo");

Console.WriteLine("Informe a medida do raio em centímetros");
double raio = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Informe a medida da altura em centímetros");
double altura = Convert.ToDouble(Console.ReadLine());

double volume = (Math.PI * Math.Pow(raio, 2) * altura);

Console.WriteLine($"O volume da lata de óleo é {Math.Round(volume, 2)} cm³.");