using MP01;

void NicePrint(string text)
{
    Console.WriteLine("=======================");
    Console.WriteLine($"--- {text} ---");
}


NicePrint("Czy wczytać łuczników z pliku archers.json? (t/n)");
var response = Console.ReadLine();
if (response == "t") Archer.DeserializeArchers();

NicePrint("Lista łuczników po wczytaniu z pliku:");
foreach (var archer in Archer.GetArchers()) Console.WriteLine(archer);

var arrowSet1 = new List<Arrow>();
for (var i = 0; i < 12; i++)
    arrowSet1.Add(new Arrow
    {
        ArrowheadMaterial = ArrowheadMaterial.Wolfram,
        Length = 43.2,
        Material = "Carbon"
    });

var arrowSet2 = new List<Arrow>();
for (var i = 0; i < 12; i++)
    arrowSet2.Add(new Arrow
    {
        ArrowheadMaterial = ArrowheadMaterial.StainlessSteel,
        Length = 36.5,
        Material = "Aluminium"
    });

var arrowSet3 = new List<Arrow>();
for (var i = 0; i < 12; i++)
    arrowSet3.Add(new Arrow
    {
        ArrowheadMaterial = ArrowheadMaterial.Aluminium,
        Length = 50.0,
        Material = "Carbon"
    });

var arrowSet4 = new List<Arrow>();
for (var i = 0; i < 12; i++)
    arrowSet4.Add(new Arrow
    {
        ArrowheadMaterial = ArrowheadMaterial.StainlessSteel,
        Length = 24,
        Material = "Aluminium"
    });

var archer1 = new Archer(arrowSet1, new DateOnly(2021, 10, 1))
{
    PhoneNumber = "123456789",
    Names = new List<string> { "John", "Doe" }
};

var archer3 = new Archer(arrowSet2.Slice(0, 6), DateOnly.MaxValue)
{
    PhoneNumber = "261874021",
    Names = new List<string> { "Professor", "Professorki" }
};

var archer2 = new Archer(arrowSet3, new DateOnly(2019, 2, 13))
{
    PhoneNumber = "987654321",
    Names = new List<string> { "Adam", "Kox" }
};


var archer4 = new Archer(arrowSet4, DateOnly.MinValue)
{
    PhoneNumber = null,
    Names = new List<string> { "Piotr", "Jałocha" }
};

NicePrint("Lista łuczników:");
foreach (var archer in Archer.GetArchers()) Console.WriteLine(archer);

NicePrint("Czy zapisać łuczników do pliku archers.json? (t/n)");
response = Console.ReadLine();
if (response == "t") Archer.SerializeArchers();

NicePrint("Program zakończył działanie.");