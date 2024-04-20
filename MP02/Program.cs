using MP02;

// Asocjacja kwalifikowana (całość)
var bow1 = new Bow(Material.Wood);

// Asocjacja kwalifikowana (część)
// Asocjacja "zwykła"
// Asoscjacja z atrybutem
var archer1 = Archer.CreateArcher(bow1, ["Jakiś", "Debil"]);

// Asocjacja "zwykła"
var coach1 = new Coach(["Roman", "Pękalski"]);
archer1.AddCoach(coach1);

// Asoscjacja z atrybutem
var compteition1 = new Competition("Mistrzostwa Polski");
var compete1 = new Compete(compteition1, archer1, 600, new DateOnly(2021, 12, 12));


Console.WriteLine(archer1);
Console.WriteLine(coach1);

Console.WriteLine(compete1);