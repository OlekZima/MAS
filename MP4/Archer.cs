namespace MP4;

public class Archer
{
    private Bow? Bow { get; set; }
    
    public void SetBow(Bow bow)
    {
        Bow = bow;
        bow.AddUser(this);
    }
    
    public void RemoveBow()
    {
        if (Bow == null)
        {
            Console.WriteLine("\nThis archer is not assigned to any bow.\nCannot remove the bow.\n");
            return;
        }
        Bow.RemoveUser(this);
        Bow = null;
    }

    public override string ToString()
    {
        return $"Archer with bow: {Bow?.GetManufacturer()} {Bow?.GetModel()}";
    }
}
public class ArcherGroup
{
    private List<Archer> archers = [];
    private Coach? coach;

    public ArcherGroup(Coach coach)
    {
        this.coach = coach;
    }

    public void AddArcher(Archer archer)
    {
        if (!archers.Contains(archer))
        {
            archers.Add(archer);
        }
    }

    public void RemoveArcher(Archer archer)
    {
        if (!archers.Contains(archer))
        {
            Console.WriteLine("Cannot remove an archer who is not a member.\n");
            return;
        }
        archers.Remove(archer);
    }

    public List<Archer> GetArchers()
    {
        return new List<Archer>(archers);
    }

    public bool Contains(Archer archer)
    {
        return archers.Contains(archer);
    }
}
