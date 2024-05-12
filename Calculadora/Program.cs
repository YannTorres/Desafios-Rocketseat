using Calculadora;

Console.Write("Digite um numero: ");
var numero1 = double.Parse(Console.ReadLine()!);

Console.Write("Digite outro numero: ");
var numero2 = double.Parse(Console.ReadLine()!);

var soma = OperaçõesNumericas.Soma(numero1, numero2);
var subtracao = OperaçõesNumericas.Subtração(numero1, numero2);
var multiplicacao = OperaçõesNumericas.Multiplicação(numero1, numero2);
var divisao = OperaçõesNumericas.Divisão(numero1, numero2);
var media = OperaçõesNumericas.Media(numero1, numero2);

Console.WriteLine($"Soma: {soma}");
Console.WriteLine($"Subtração: {subtracao}");
Console.WriteLine($"Multiplicação: {multiplicacao}");
Console.WriteLine($"Divisão: {divisao}");
Console.WriteLine($"Média: {media}");