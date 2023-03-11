/*19. O IMC – Índice de Massa Corporal é um critério da Organização Mundial de Saúde para dar uma indicação sobre
a condição de peso de uma pessoa adulta. A fórmula é IMC = peso / (altura) ². Elabore um algoritmo que leia o
peso e a altura de um adulto e mostre sua condição*/

Console.Clear();
Console.WriteLine("Calcular IMC\n");
Console.WriteLine("Informe o peso:");
double peso = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Informe a altura:");
double altura = Convert.ToDouble(Console.ReadLine());

double imc = Math.Round(peso / (altura * altura), 2);

string classificacao = string.Empty;
if (imc < 16)
    classificacao = "Magreza Grau III";
if (imc >= 16 && imc <= 16.9)
    classificacao = "Magreza Grau II";
if (imc >= 17 && imc <= 18.4)
    classificacao = "Magreza Grau I";
if (imc >= 18.5 && imc <= 24.9)
    classificacao = "Eutrofia";
if (imc >= 25 && imc <= 29.9)
    classificacao = "Sobrepeso";
if (imc >= 30 && imc <= 34.9)
    classificacao = "Obesidade Grau I";
if (imc >= 35 && imc <= 34.9)
    classificacao = "Obesidade Grau II";
if (imc > 40)
    classificacao = "Obesidade Grau III";

Console.Clear();
Console.WriteLine($"Seu IMC é: {imc}\nClassificação: {classificacao}\n");







