using SzepNev.Data;
using SzepNev.Models;

var db = new GameContext();

//db.Games.Add(new Game("Need for speed", "Egy másik ikonikus játék", 8000));

Console.Write("Add meg az üzenetedet: ");
string uzenet = Console.ReadLine();

db.Messages.Add(new Message("Norina", uzenet));
db.SaveChanges();

do
{
    Console.Clear();
    foreach (var message in db.Messages)
    {
        Console.WriteLine($"{message.UserName} - {message.Content}");
    }
    if (Console.KeyAvailable) {
        var c = Console.ReadKey(true);
        if (c.Key == ConsoleKey.Escape) break;
        if (c.Key == ConsoleKey.N)
        {
            Console.WriteLine();
            Console.Write("Add meg az üzenetedet: ");
            string ujUzenet = Console.ReadLine();
            db.Messages.Add(new Message("Norina", ujUzenet));
            db.SaveChanges();
        }
    }
    else
    {
        Thread.Sleep(1000);
    }
} while (true);