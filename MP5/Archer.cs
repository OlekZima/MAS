namespace MP5;

public class Archer : Person
{
    public int CoachId { get; set; }

    public Coach? Coach { get; set; }

    public override void Train()
    {
        Console.WriteLine("Archer is training");
    }

    public override string ToString()
    {
        return string.Join(" ", Names) + " " + Id;

    }
}