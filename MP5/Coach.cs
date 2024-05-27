namespace MP5;

public class Coach : Person
{
    public int ArcherId { get; set; }

    public List<Archer>? Archers = [];

    public override void Train()
    {
        Console.WriteLine("Coach is training");
    }

    public override string ToString()
    {
        return string.Join(" ", Names) + " " + Id;

    }
}