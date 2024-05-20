namespace MP02;

public class Competition
{
    private static int _idCounter = 1;
    private readonly List<Compete> _competes = [];

    public Competition(string name)
    {
        Name = name;
        Id = _idCounter;
        _idCounter++;
    }

    public string Name { get; init; }

    public int Id { get; init; }

    public Archer? GetArcher(int archerId)
    {
        return (from compete in _competes where compete.GetArcher().Id == archerId select compete.GetArcher())
            .FirstOrDefault();
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