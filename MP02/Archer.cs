using System.Text;

namespace MP02;

public class Archer
{
    private Coach? _coach;
    public List<string> Names { get; init; }


    public void AddCoach(Coach coach)
    {
        if (_coach != null) return;

        _coach = coach;
        coach.AddArcher(this);
    }

    public override string ToString()
    {
        var namesStr = new StringBuilder("Archer ");
        foreach (var name in Names) namesStr.Append($"{name} ");

        return $"{namesStr}has a coach {_coach}";
    }
}