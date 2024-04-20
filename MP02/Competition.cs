namespace MP02;

public class Competition
{
    private static int _idCounter;
    private readonly List<Archer> _archers = [];

    public Competition(string name)
    {
        Name = name;
        Id = _idCounter;
        _idCounter++;
    }

    public string Name { get; init; }

    public int Id { get; init; }


    public void AddArcher(Archer archer)
    {
        if (!_archers.Contains(archer))
            _archers.Add(archer);
        else
            throw new Exception($"Archer {string.Join(" ", archer.Names)} is already in the competition!");
    }
}