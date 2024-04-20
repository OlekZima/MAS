namespace MP02;

public class Compete
{
    private static int _idCounter = 1;
    private readonly Archer _archer;
    private readonly Competition _competition;

    public Compete(Competition competition, Archer archer, int score, DateOnly date)
    {
        _competition = competition;
        _archer = archer;
        Score = score;
        Date = date;
        Id = _idCounter;
        _idCounter++;
    }

    public int Id { get; init; }

    private int Score { get; }

    private DateOnly Date { get; }

    public Archer GetArcher()
    {
        return _archer;
    }

    public Competition GetCompetition()
    {
        return _competition;
    }

    public override string ToString()
    {
        return $"Archer {_archer} scored {Score} points at competition {_competition.Name} {_competition.Id} on {Date}";
    }
}