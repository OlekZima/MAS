using System.Text;

namespace MP02;

public class Archer
{
    private static int _idCounter = 1;
    private readonly List<Compete> _competes = [];
    private Bow _bow;
    private Club _club;
    private Coach _coach;

    private Archer(Bow bow, List<string> names, Club club)
    {
        _bow = bow;
        Names = names;
        _club = club;
        _club.AddMember(this);
        Id = _idCounter;
        _idCounter++;
    }

    public int? Id { get; set; }

    public List<string> Names { get; init; }

    public static Archer CreateArcher(Bow? bow, List<string> names, Club club)
    {
        if (bow == null) throw new Exception("This bow does not exist!");

        var archer = new Archer(bow, names, club);
        bow.AddArcher(archer);
        return archer;
    }

    public Competition? GetCompetition(int competitionId)
    {
        return (from compete in _competes
                where compete.GetCompetition().Id == competitionId
                select compete.GetCompetition())
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
        if (_bow == null) return "This archer is not more exist!";
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

    public Bow GetBow()
    {
        return _bow;
    }

    public void RemoveBow(Bow bow)
    {
        if (_bow == bow)
        {
            _club = null;
            _coach = null;
            _competes.Clear();
            _bow = null;
            Console.WriteLine($"Archer {string.Join(" ", Names)} is not longer a member of any club and has no coach!");
        }
        else
        {
            throw new Exception("This archer does not use this bow!");
        }
    }
}