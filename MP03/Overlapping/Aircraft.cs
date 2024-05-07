namespace MP03.Overlapping;

public class Aircraft
{
    private readonly int _id;
    private static int _idCounter = 1;
    public string Model;
    public int YearOfProduction;


    private Dictionary<LinkType, object> _roles = new();


    public Aircraft(string model, int yearOfProduction)
    {
        Model = model;
        YearOfProduction = yearOfProduction;
        _id = _idCounter;
        _idCounter++;
    }

    public Aircraft(string model, int yearOfProduction, int numberOfBombs, int cargoCapacity) : this(model,
        yearOfProduction)
    {
        AddBomber(numberOfBombs, cargoCapacity);
    }

    public void AddBomber(int numberOfBombs, int cargoCapacity)
    {
        if (_roles.ContainsKey(LinkType.Bomber)) return;
        var bomber = new BomberAircraft(numberOfBombs, cargoCapacity);
        _roles[LinkType.Bomber] = bomber;
    }

    public void AddFighterJet(int numberOfMissiles, int maxSpeed)
    {
        if (_roles.ContainsKey(LinkType.FighterJet)) return;
        var fighterJet = new FighterJetAircraft(numberOfMissiles, maxSpeed);
        _roles[LinkType.FighterJet] = fighterJet;
    }

    public BomberAircraft? GetBomber()
    {
        return _roles.TryGetValue(LinkType.Bomber, out var bomber) ? bomber as BomberAircraft : null;
    }

    public FighterJetAircraft? GetFighterJet()
    {
        return _roles.TryGetValue(LinkType.FighterJet, out var fighterJet) ? fighterJet as FighterJetAircraft : null;
    }

    public int GetId()
    {
        return _id;
    }

    public int GetNumberOfBombs()
    {
        return GetBomber()?.GetNumberOfBombs() ?? throw new Exception("Bomber not found");
    }
    
    public int GetNumberOfMissiles()
    {
        if (_roles.TryGetValue(LinkType.FighterJet, out var fighterJet))
        {
            return (fighterJet as FighterJetAircraft)?.GetNumberOfMissiles() ?? 0;
        }
        throw new Exception("Fighter jet not found");
    }
    
    public override string ToString()
    {
        var info = $"Id: {_id}, Aircraft {Model}, produced in {YearOfProduction}";
        if (_roles.ContainsKey(LinkType.Bomber))
        {
            info += $", {GetBomber()}";
        }
        if (_roles.ContainsKey(LinkType.FighterJet))
        {
            info += $", {GetFighterJet()}";
        }
        return info;
    }
}