using System.Text;

namespace MP02;

public class Archer
{
    private readonly Bow _bow;
    private Coach _coach;

    private Archer(Bow bow, List<string> names)
    {
        _bow = bow;
        Names = names;
    }

    public List<string> Names { get; init; }

    public static Archer CreateArcher(Bow? bow, List<string> names)
    {
        if (bow == null) throw new Exception("This bow does not exist!");

        var archer = new Archer(bow, names);
        bow.AddArcher(archer);
        return archer;
    }


    public void AddCoach(Coach coach)
    {
        if (_coach != null)
        {
            Console.WriteLine($"Archer {string.Join(" ", Names)} already has a coach!");
            return;
        }

        _coach = coach;
        coach.AddArcher(this);
    }

    public override string ToString()
    {
        var namesStr = new StringBuilder("Archer ");
        foreach (var name in Names) namesStr.Append($"{name} ");
        return $"{namesStr}has a coach {_coach}, {_bow}";
    }
}