using System.Runtime.CompilerServices;

string NomeUsuario;

Console.BackgroundColor = ConsoleColor.White;
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine("--- Nome Ninja ---\n");
Console.ResetColor();

Console.WriteLine();
Console.Write("Digite seu Nome: ");

NomeUsuario = Console.ReadLine();

NomeUsuario = NomeUsuario.Trim().ToLower()
                         .Replace("a","ka")   
                         .Replace("b","zu")
                         .Replace("c","mi")
                         .Replace("d","te")
                         .Replace("e","ku")
                         .Replace("f","lu")
                         .Replace("g","ji")
                         .Replace("h","ri")
                         .Replace("i","ki")
                         .Replace("j","zus")
                         .Replace("k","me")
                         .Replace("l","ta")
                         .Replace("m","rin")
                         .Replace("n","to")
                         .Replace("o","mo")
                         .Replace("p","no")
                         .Replace("q","ke")
                         .Replace("r","shi")
                         .Replace("s","ari")
                         .Replace("t","chi")
                         .Replace("u","do")
                         .Replace("v","ru")
                         .Replace("w","mei")
                         .Replace("x","na")
                         .Replace("y","fu")
                         .Replace("z","zi");

                     Console.WriteLine($"Seu nome ninja é {NomeUsuario}");    
