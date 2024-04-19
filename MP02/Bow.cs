namespace MP02;

public enum Material
{
    Wood,
    Carbon
}

public class Bow(int id, Material material)
{
    private readonly List<Archer> _archers = [];
    public int Id { get; init; }

    public Material GetMaterial()
    {
        return material;
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
        return $"Bow {Id} made of {material}";
    }
}