namespace MP02;

public enum Material
{
    Wood,
    Carbon
}

public class Bow
{
    private static int _idCounter = 1;
    private static readonly List<Bow> _bows = 
    private readonly List<Archer> _archers = 
    private readonly Material _material;

    public Bow(Material material)
    {
        _material = material;
        Id = _idCounter;
        _idCounter++;
        _bows.Add(this);
    }

    public int Id { get; init; }
    [];[];


    public Material GetMaterial()
    {
        return _material;
    }

    public void AddArcher(Archer archer)
    {
        if (!_archers.Contains(archer))
            _archers.Add(archer);
        else
            throw new Exception($"Archer {string.Join(" ", archer.Names)} already uses this bow!");
    }

    public static IReadOnlyCollection<Bow> GetBows()
    {
        return _bows.AsReadOnly();
    }

    public void DeleteBow()
    {
        var archersToBeDeleted = new List<Archer>(_archers);
        foreach (var archer in archersToBeDeleted)
        {
            archer.RemoveBow(this);
            DeleteArcher(archer);
        }

        _bows.Remove(this);
    }

    private void DeleteArcher(Archer archer)
    {
        if (_archers.Contains(archer))
        {
            _archers.Remove(archer);
            Console.WriteLine($"Archer {string.Join(" ", archer.Names)} no longer uses this bow!");
        }
        else
        {
            Console.WriteLine($"Archer {string.Join(" ", archer.Names)} does not use this bow!");
        }
    }

    public override string ToString()
    {
        return $"Bow {Id} made of {_material};";
    }
}