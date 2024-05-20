using MP03;
using MP03.Dynamic;
using MP03.Multi_faceted_Inheritance;
using MP03.Multiple_Inheritance;
using MP03.Overlapping;

var archer1 = new Archer(["Jakiś", "Debil"],
    new DateOnly(2000, 12, 24), new DateOnly(2020, 12, 24), 150, AccessLevel.Zero);

var coach1 = new Coach(["Roman", "Pękalski"],
    new DateOnly(1980, 9, 2), new DateOnly(1990, 2, 4), 5000, AccessLevel.Two);

Console.WriteLine("=====Archer=====");
Console.WriteLine(archer1.GetIncome());
Console.WriteLine(archer1.GetScholarship());
Console.WriteLine("Access Level");
Console.WriteLine(archer1.GetAccessLevel());
Console.WriteLine("Train");
archer1.Train(coach: coach1);

Console.WriteLine();

Console.WriteLine("=====Coach=====");
Console.WriteLine(coach1.GetIncome());
Console.WriteLine(coach1.GetSalary());
Console.WriteLine("Access Level");
Console.WriteLine(coach1.GetAccessLevel());
Console.WriteLine("Train");
coach1.Train(archer: archer1);


var aircraft1 = new Aircraft("F-16", 1970);
Console.WriteLine(aircraft1);

aircraft1.AddBomber(20, 2000);
Console.WriteLine(aircraft1);

aircraft1.AddFighterJet(20, 2);
Console.WriteLine(aircraft1);

Console.WriteLine(aircraft1.GetBomber());
Console.WriteLine(aircraft1.GetNumberOfMissiles());


Console.WriteLine("=====ArcherCoach=====");
var archerCoach1 = new ArcherCoach(["Jakiś", "Debil"],
    new DateOnly(2000, 12, 24), new DateOnly(2020, 12, 24), 25, AccessLevel.Three, archer1);

Console.WriteLine(archerCoach1.GetIncome());
Console.WriteLine(archerCoach1.GetScholarship());
Console.WriteLine(archerCoach1.GetSalary());

Console.WriteLine("Access Level");
Console.WriteLine(archerCoach1.GetAccessLevel());


Console.WriteLine("=====Cups=====");

var ceramicCup1 = new CeramicCup("Ceramic1", 0.2, 0.3, 20);
Console.WriteLine(ceramicCup1);
var glassCup1 = new GlassCup("Glass1", 0.1, 0.2, 10);
Console.WriteLine(glassCup1);

var cupPurposeKitchen1 = CupPurposeKitchen.CreateCupPurposeKitchen(ceramicCup1, true) as CupPurposeKitchen;
Console.WriteLine(cupPurposeKitchen1);
var cupPurposeRestaurant1 = CupPurposeRestaurant.CreateCupPurposeRestaurant(glassCup1, false) as CupPurposeRestaurant;
Console.WriteLine(cupPurposeRestaurant1);

cupPurposeKitchen1.SetIsDishwasherSafe(true);

Console.WriteLine(cupPurposeKitchen1.GetIsDishwasherSafe());
Console.WriteLine(cupPurposeRestaurant1.GetIsClean());
Console.WriteLine(cupPurposeKitchen1.GetCup());


Console.WriteLine("=====Essence=====");

var reason1 = "x1";
var date1 = new DateOnly(2020, 12, 24);
var life1 = new Life(20, date1, reason1);
Console.WriteLine(life1);

var reason2 = "x2";
var date2 = new DateOnly(2020, 12, 25);
var death1 = new Death(life1, 40);
Console.WriteLine(death1);