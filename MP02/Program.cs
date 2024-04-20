using MP02;

// Asocjacja kwalifikowana (całość)
var bow1 = new Bow(0, Material.Carbon);

// Asocjacja kwalifikowana (część)
// Asocjacja "zwykła"
var archer1 = Archer.CreateArcher(bow1, ["Jakiś", "Debil"]);

// Asocjacja "zwykła"
var coach1 = new Coach(["Roman", "Pękalski"]);

var compteition1 = new Competition("Mistrzostwa Polski");
var compteition2 = new Competition("Mistrzostwa Polski 2");
var compteition3 = new Competition("Mistrzostwa Polski 3");
Console.WriteLine(compteition1.Id);
Console.WriteLine(compteition2.Id);
Console.WriteLine(compteition3.Id);


archer1.AddCoach(coach1);

Console.WriteLine(archer1);
Console.WriteLine(coach1);