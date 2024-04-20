using System.Text;

namespace MP02;

public class Archer
{
    private static int _idCounter = 1;
    private readonly Bow _bow;
    private readonly List<Compete> _competes = [];
    private Coach _coach;

    private Archer(Bow bow, List<string> names)
    {
        _bow = bow;
        Names = names;
        Id = _idCounter;
        _idCounter++;
    }

    public int Id { get; init; }

    public List<string> Names { get; init; }

    public static Archer CreateArcher(Bow? bow, List<string> names)
    {
        if (bow == null) throw new Exception("This bow does not exist!");

        var archer = new Archer(bow, names);
        bow.AddArcher(archer);
        return archer;
    }

    public Competition? GetCompetition(int competitionId)
    {
        return (from compete in _competes where compete.GetCompetition().Id == competitionId select compete.GetCompetition())
            .FirstOrDefault();
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

    public void AddCompete(Compete compete)
    {
        if (_competes.Contains(compete))
        {
            Console.WriteLine("This compete already exists!");
            return;
        }

        _competes.Add(compete);
    }
}