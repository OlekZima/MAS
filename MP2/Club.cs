namespace MP02;

public class Club
{
    private readonly Dictionary<string, Archer> _members = new();
    public string Name;

    public Club(string name)
    {
        Name = name;
    }

    public void AddMember(Archer archer)
    {
        if (_members.ContainsKey(archer.Names[0])) return;
        _members.Add(archer.Names[^1], archer);
    }

    public Archer GetMember(string name)
    {
        if (_members.TryGetValue(name, out var value)) return value;
        throw new Exception("No member with this name!");
    }

    public override string ToString()
    {
        return $"Club {Name} has members: {string.Join("; ", _members.Keys)}";
    }
}