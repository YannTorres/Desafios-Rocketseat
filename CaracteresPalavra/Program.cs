Console.Write("Digite uma Frase ou Palavra: ");
var palavra = Console.ReadLine()!;
var Array = palavra.Replace(" ", "").Trim().ToCharArray();

Console.WriteLine(Array.Length);


