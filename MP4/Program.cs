using MP4;

// Ograniczenie Unique oraz Atrybutu
var bow1 = new Bow(BowManufacturer.Hoyt, "model1", 3);

var bow2 = new Bow(BowManufacturer.BearArchery, "model2", 6);
bow1.SetActiveUsers(6);

var bow3 = new Bow(BowManufacturer.Mathews, "model1", 2);

// Ograniczenie Ordered
var bows = Bow.GetBows();
foreach (var bow in bows)
{
    Console.WriteLine($"Manufacturer: {bow.GetManufacturer()}, Model: {bow.GetModel()}, Active users: {bow.GetActiveUsers()}");
}

// Ograniczenie XOR
var archer1 = new Archer();
var engineer = new Engineer();
var temporaryBow1 = new Bow(BowManufacturer.Bowtech, "model3", 1);

archer1.SetBow(bow1);
Console.WriteLine(archer1);

bow1.SetEngineer(engineer, temporaryBow1);
Console.WriteLine(archer1);
bows = Bow.GetBows();
foreach (var bow in bows)
{
    Console.WriteLine($"Manufacturer: {bow.GetManufacturer()}, Model: {bow.GetModel()}, Active users: {bow.GetActiveUsers()}");
}


engineer.RemoveBow(bow1);
Console.WriteLine(archer1);



var archer4 = new Archer();
var archer5 = new Archer();
var archer6 = new Archer();

var coach = new Coach();

//
// coach.AddMemberArcher(archer5);
//
// coach.AddTrainedArcher(archer6);
//
// coach.AddTrainedArcher(archer4);
// coach.AddTrainedArcher(archer5);
//
// Console.WriteLine("Member Archers:");
// foreach (var archer in coach.GetMemberArchers())
// {
//     Console.WriteLine(archer);
// }
//
// Console.WriteLine("Trained Archers:");
// foreach (var archer in coach.GetTrainedArchers())
// {
//     Console.WriteLine(archer);
// }
//
// coach.RemoveMemberArcher(archer4);
//
// coach.RemoveTrainedArcher(archer4);
//
// coach.RemoveMemberArcher(archer4);

// Console.WriteLine("Member Archers after removal:");
// foreach (var archer in coach.GetMemberArchers())
// {
//     Console.WriteLine(archer);
// }
//
// Console.WriteLine("Trained Archers after removal:");
// foreach (var archer in coach.GetTrainedArchers())
// {
//     Console.WriteLine(archer);
// }
