namespace MP02;

public class Coach
{
    private List<Archer> _archers = [];

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

    public void RemoveArcher(Archer archer)
    {
        if (!_archers.Contains(archer)) return;
        _archers.Remove(archer);
        archer.RemoveCoach(this);
    }

    public override string ToString()
    {
        var coachNames = string.Join(" ", Names);
        var archerNames = _archers.Select(a => string.Join(" ", a.Names));

        return $"Coach {coachNames} is training archers: {string.Join("; ", archerNames)}";
    }
}