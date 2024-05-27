namespace MP4;

public enum BowManufacturer
{
    Hoyt,
    BearArchery,
    Mathews,
    Bowtech
}

public class Bow
{
    private List<Archer> Users { get; set; } = [];
    private Engineer? Engineer { get; set; }
    private static List<Bow> BowsExtension { get; set; } = [];
    private BowManufacturer Manufacturer { get; set; }

    // Ograniczenie Unique
    private string Model { get; set; }
    private static HashSet<string> Models { get; set; } = [];
    private int ActiveUsers { get; set; }

    public void SetEngineer(Engineer engineer, Bow temporaryBow)
    {
        var usersCopy = new List<Archer>(Users);
        foreach (var archer in usersCopy)
        {
            archer.RemoveBow();
            archer.SetBow(temporaryBow);
        }

        Users = usersCopy;
        
        Console.WriteLine(Engineer != null
            ? "\nChanging the engineer to repair the bow.\n"
            : "\nSetting the engineer to repair the bow.\n");
        engineer.AddBow(this, temporaryBow);
        Engineer = engineer;
    }
    
    public void RemoveEngineer()
    {
        if (Engineer == null)
        {
            Console.WriteLine("\nThis bow is not assigned to any engineer.\nCannot remove the engineer.\n");
            return;
        }
        Engineer.RemoveBow(this);
        Engineer = null;
    }

    public void AddUser(Archer user)
    {
        if (Users.Contains(user))
        {
            Console.WriteLine("\nThis user is already assigned to this bow.\nCannot add the same user twice.\n");
            return;
        }

        Users.Add(user);
    }

    public void RemoveUser(Archer user)
    {
        if (!Users.Contains(user))
        {
            Console.WriteLine("\nThis user is not assigned to this bow.\nCannot remove the user.\n");
            return;
        }

        Users.Remove(user);
    }

    public BowManufacturer GetManufacturer()
    {
        return Manufacturer;
    }

    public string GetModel()
    {
        return Model;
    }

    public int GetActiveUsers()
    {
        return ActiveUsers;
    }
    
    public List<Archer> GetUsers()
    {
        return Users;
    }
    
    public Bow(BowManufacturer manufacturer, string model, int activeUsers)
    {
        // Ograniczenie Unique
        if (Models.Contains(model.ToLower()))
        {
            Console.WriteLine("\nThis model already exists.\nCannot create a new instance.\n");
            return;
        }

        // Ograniczenie atrybutu
        if (activeUsers > 5)
        {
            Console.WriteLine("\nThis bow has too many users.\nCannot create a new instance.\n");
            return;
        }

        BowsExtension.Add(this);
        ActiveUsers = activeUsers;
        Manufacturer = manufacturer;
        Model = model.ToLower();
    }

    // Ograniczenie atrybutu
    public void SetActiveUsers(int activeUsers)
    {
        if (activeUsers > 5)
        {
            Console.WriteLine("\nThis bow has too many users.\nCannot set new value.\n");
            return;
        }

        ActiveUsers = activeUsers;
    }

    public static List<Bow> GetBows()
    {
        return new List<Bow>(BowsExtension);
    }

    public override string ToString()
    {
        return $"Bow: {Manufacturer} {Model}";
    }
}