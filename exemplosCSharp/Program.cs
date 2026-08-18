using exemplosCSharp.fixacao;

Console.WriteLine("Informe a medida em metros:");
int metros = int.Parse(Console.ReadLine());

int milimetros = MetrosMilimetross.ConverterMetrosParaMilimetros(metros);
Console.WriteLine("A medida em milímetros é: " + milimetros);