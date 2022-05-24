
Console.WriteLine("Szia! Hogy hívnak?");
string nev = Console.ReadLine();
Console.Clear();
Console.WriteLine($"Szia {nev}! Nagyon szép neved van! <3");
Console.WriteLine("Nézd!");
Random rnd = new();
for (int i = 0; i < 100; i++)
{
    Console.SetCursorPosition(
        rnd.Next(Console.WindowWidth),
        rnd.Next(2, Console.WindowHeight));

    Console.ForegroundColor = (ConsoleColor)rnd.Next(1, 16);
    Console.WriteLine(nev);

    Thread.Sleep(100);
}
Console.ReadKey(true);