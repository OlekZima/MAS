using System.Text;

namespace MP02;

public class Coach
{
    private readonly List<Archer> _archers = new();
    public List<string> Names { get; init; }

    public void AddArcher(Archer archer)
    {
        if (_archers.Contains(archer))
        {
            return;
        }
        _archers.Add(archer);
        archer.AddCoach(this);
    }

    public override string ToString()
    {
        var stringBuilder = new StringBuilder("Coach ");
        foreach (var name in Names) stringBuilder.Append($"{name} ");

        var archersNames = new StringBuilder("is training archers: ");
        foreach (var archer in _archers)
        {
            var archerNamesStr = new StringBuilder();
            var whiteChar = " ";
            for (var i = 0; i < archer.Names.Count; i++)
            {
                if (i == archer.Names.Count) whiteChar = "; ";
                archerNamesStr.Append($"{archer.Names[i]}{whiteChar}");
            }

            archersNames.Append(archerNamesStr);
        }

        return stringBuilder.Append(archersNames).ToString();
    }
}