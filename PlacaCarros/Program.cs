using System.Text.RegularExpressions;

Console.Write("Digite uma Placa: ");
var placa = Console.ReadLine()!;

if (placa.Length < 7)
{
    Console.WriteLine("Falso");
} else
{
    var letras = placa.Substring(0, 3);
    var numeros = placa.Substring(4, 3);

    if (letras.All(char.IsLetter) && numeros.All(char.IsNumber))
    {
        Console.WriteLine("Verdadeiro");
    } else
    {
        Console.WriteLine("Falso");
    }

}
