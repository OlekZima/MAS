using MP02;

var bow1 = new Bow(0, Material.Carbon);

var archer1 = Archer.CreateArcher(bow1, ["Jakiś", "Debil"]);

var coach1 = new Coach(["Roman", "Pękalski"]);

archer1.AddCoach(coach1);

Console.WriteLine(archer1);
Console.WriteLine(coach1);