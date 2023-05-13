Console.Clear();
String Texto, Baleeis;

Console.WriteLine("Digite um texto.");
Texto = Console.ReadLine();

Console.WriteLine();

Baleeis = Texto
.Replace("a", "aaa")
.Replace("e", "eee")
.Replace("i", "iii")
.Replace("o", "ooo")
.Replace("u", "uuu")
.Replace("A", "AAA")
.Replace("E", "EEE")
.Replace("I", "III")
.Replace("O", "OOO")
.Replace("U", "UUU");
Console.WriteLine(Baleeis);


