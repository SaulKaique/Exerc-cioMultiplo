Console.Clear();

int N1,N2 ;


Console.ForegroundColor = ConsoleColor.Green;
Console.Write("--- Múltiplo ---\n");
Console.ResetColor();


Console.ForegroundColor = ConsoleColor.Yellow;
Console.Write("Digite Um numero...:");
N1 = Convert.ToInt32(Console.ReadLine());
Console.ResetColor();



Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.Write("Digite Um numero...:");
N2 = Convert.ToInt32(Console.ReadLine());
Console.ResetColor();


if (N1 % N2 == 0)
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine($"\n{N1} È Múltiplo de {N2}");
    Console.ResetColor();

}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"\n{N1} Não é Múltiplo de {N2}");
    Console.ResetColor();

}
