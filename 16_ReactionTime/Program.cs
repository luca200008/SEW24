// See https://aka.ms/new-console-template for more information
using _16_ReactionTime;
Console.WriteLine("Hello, World!");

// Schleife mit 10 zufälligen Buchstaben (Kleinbuchstaben)
// Am Ende die vergangerne Zeit

Random random = new Random();

//DateTime start = DateTime.Now;
Stopwatch watch = new Stopwatch();
for (int i =  0; i < 10; i++)
{
    int number = random.Next(0, 26);
    char letter = (char)('a' + number);        // ascii vom 'a' + Zufallszahl
    Console.WriteLine(letter);
    ConsoleKeyInfo keyInfo = Console.ReadKey();
    if (keyInfo.KeyChar != letter)
    {
        Console.WriteLine("Spiel zu Ende! Falsche Taste!");
        return;
    }
}
//DateTime end = DateTime.Now;
TimeSpan elapsed = watch.Elapse();
Console.WriteLine($"Zeit: {(elapsed).TotalSeconds:f2}");      //end-stark leifert TimeSpan


