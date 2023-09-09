Console.WriteLine(" --- Pet shop Entrada --- \n");

Console.WriteLine("Espécie:");
string especie = Console.ReadLine()!;

Console.WriteLine("Raça:");
string raça = Console.ReadLine()!;

Console.WriteLine("Apelido/nome:");
string apelido = Console.ReadLine()!;

Console.WriteLine("Idade (anos):");
string idade = Console.ReadLine()!;

Console.WriteLine("Pelagem (cor):");
string pelagem = Console.ReadLine()!;

Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine("+---------------------------------------------------------+");
Console.Write("|                 ");

Console.ForegroundColor = ConsoleColor.DarkRed;
Console.Write("      PET SHOP");

Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine("                          |");
Console.WriteLine("+---------------------------------------------------------+");

Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.Write("| Espécie: ");
Console.ForegroundColor = ConsoleColor.Yellow;
Console.Write(especie.Trim().ToUpper().PadLeft(15, '.').Substring(0, 15));

Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine("                                |");
Console.WriteLine("+---------------------------------------------------------+");

Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.Write("| Raça: ");
Console.ForegroundColor = ConsoleColor.Yellow;
Console.Write(raça.Trim().ToUpper().PadLeft(22, '.').Substring(0, 22));

Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine("                            |");
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine("+---------------------------------------------------------+");

Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.Write("| Atende pelo apelido de: ");
Console.ForegroundColor = ConsoleColor.Yellow;
Console.Write(apelido.Trim().ToUpper().PadLeft(31, '.').Substring(0, 31));

Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine(" |");
Console.WriteLine("|+--------------------------------------------------------+");

Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.Write("| Idade: ");
Console.ForegroundColor = ConsoleColor.Yellow;
Console.Write($"{idade.Trim().ToUpper().PadLeft(2, '0').Substring(0, 2)} ano(s)");

Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine("                                        |");
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine("+---------------------------------------------------------+");

Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.Write("| Pelagem(cor): ");
Console.ForegroundColor = ConsoleColor.Yellow;
Console.Write(pelagem.Trim().ToUpper().PadLeft(23, '.').Substring(0, 23));

Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine("                   |");
Console.WriteLine("+---------------------------------------------------------+");

Console.ResetColor();