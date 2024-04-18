using MP02;

var archer1 = new Archer
{
    Names = new List<string> { "Jakiś", "Debil" }
};

var coach1 = new Coach
{
    Names = new List<string> { "Roman", "Pękalski" }
};


archer1.AddCoach(coach1);

// archer1.AddCoach(coach1);
// coach1.AddArcher(archer1);
// coach1.AddArcher(archer1);

Console.WriteLine(archer1);

Console.WriteLine(coach1);