using MP02;

// Asocjacja z kwalifikatorem
var club1 = new Club("Łucznik Żywiec");
var club2 = new Club("Zbójnik Żywiec");

// Kompozycja (całość)
var bow1 = new Bow(Material.Wood);
var bow2 = new Bow(Material.Carbon);

// Kompozycja(część)
// Asocjacja "zwykła"
// Asoscjacja z atrybutem
// Asocjacja z kwalfikatorem
var archer1 = Archer.CreateArcher(bow1, ["Jakiś", "Debil"], club1);
var archer2 = Archer.CreateArcher(bow2, ["Andrzej", "Adamczyk"], club2);

// Asocjacja "zwykła"
var coach1 = new Coach(["Roman", "Pękalski"]);
archer1.AddCoach(coach1);
archer2.AddCoach(coach1);

// Asoscjacja z atrybutem
var compteition1 = new Competition("Mistrzostwa Polski");
var compete1 = new Compete(compteition1, archer1, 600, new DateOnly(2021, 12, 12));


Console.WriteLine(archer1);
Console.WriteLine(coach1);

Console.WriteLine(compete1);

Console.WriteLine(club1);

Console.WriteLine(club1.GetMember(archer1.Names[^1]));



Console.WriteLine("Ekstencja Bow przed usunięciem.");
Console.WriteLine(string.Join(" ", Bow.GetBows().ToList()));

Console.WriteLine("Ekstencja Archer przed usunięciem.");
Console.WriteLine(string.Join(" ", Archer.GetArchers().ToList()));
Console.WriteLine(archer1);
bow1.DeleteBow();
Console.WriteLine(archer1);

Console.WriteLine("Ekstencja Archer po usunięciu.");
Console.WriteLine(string.Join(" ", Archer.GetArchers().ToList()));


Console.WriteLine("Ekstencja Bow po usunięciem.");
Console.WriteLine(string.Join(" ", Bow.GetBows().ToList()));