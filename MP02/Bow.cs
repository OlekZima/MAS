namespace MP02;

public enum Material
{
    Wood,
    Carbon
}

public class Bow
{
    private static int _idCounter = 1;
    private readonly List<Archer> _archers = [];
    private readonly Material _material;

    public Bow(Material material)
    {
        _material = material;
        Id = _idCounter;
        _idCounter++;
    }

    public int Id { get; init; }


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

    public override string ToString()
    {
        return $"Bow {Id} made of {_material}";
    }
}