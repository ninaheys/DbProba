using SzepNev.Data;
using SzepNev.Models;

var db = new GameContext();

db.Games.Add(new Game("Need for speed", "Egy másik ikonikus játék", 8000));
db.SaveChanges();
