using MP5;

using var context = new ArcheryContext();
SQLitePCL.raw.SetProvider(new SQLitePCL.SQLite3Provider_e_sqlite3());

context.Database.EnsureDeleted();
context.Database.EnsureCreated();

var coach = new Coach { Names = ["Coach", "1"], Id = 0 };
var archer0 = new Archer { Names = ["Archer", "1"], Coach = coach, Id = 1 };
coach.Archers.Add(archer0);

var archer1 = new Archer { Names = ["Archer", "2"], Coach = coach, Id = 2 };
coach.Archers.Add(archer1);

var coach2 = new Coach { Names = ["Coach", "2"], Id = 3 };
var archer2 = new Archer { Names = ["Archer", "3"], Coach = coach2, Id = 4 };
var archer3 = new Archer() { Names = ["Archer", "4"], Coach = coach2, Id = 5 };
coach2.Archers.Add(archer2);
coach2.Archers.Add(archer3);

context.Coaches.Add(coach);
context.Coaches.Add(coach2);
context.Archers.Add(archer0);
context.Archers.Add(archer2);
context.Archers.Add(archer3);
context.Archers.Add(archer1);

context.SaveChanges();

var people = context.Coaches.ToList();
Console.WriteLine(people.Count);
foreach (var person in people)
{
    Console.WriteLine(person);
    foreach (var archerTmp in person.Archers)
    {
        Console.WriteLine(archerTmp);
    }

    for (var i = 0; i < 40; i++)
    {
        Console.Write("=");
    }

    Console.WriteLine();
}