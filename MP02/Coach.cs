namespace MP02;

public class Coach
{
    private readonly List<Archer> _archers = new();

    public Coach(List<string> names)
    {
        Names = names;
    }

    private List<string> Names { get; }

    public void AddArcher(Archer archer)
    {
        if (_archers.Contains(archer)) return;
        _archers.Add(archer);
        archer.AddCoach(this);
    }

    public override string ToString()
    {
        var coachNames = string.Join(" ", Names);
        var archerNames = _archers.Select(a => string.Join(" ", a.Names));

        return $"Coach {coachNames} is training archers: {string.Join("; ", archerNames)}";
    }
}