using System.Globalization;

Console.WriteLine("Data Atual em diferentes formatos: ");

var formatoCompleto = DateTime.Now.ToString(new CultureInfo("pt-Br"));
var formatoBrasileiro = DateOnly.FromDateTime(DateTime.Today).ToString(new CultureInfo("pt-BR"));
var Hora = DateTime.Now.ToString("HH:mm");
var Mes = DateTime.Now.ToString("MMMM");



Console.WriteLine(formatoCompleto);
Console.WriteLine(formatoBrasileiro);
Console.WriteLine(Hora);
Console.WriteLine(Mes);


