namespace MP03.Multi_faceted_Inheritance;

public abstract class Cup(string name, double weight, double volume, decimal price)
{
    private string Name { get; set; } = name;
    private double Weight { get; set; } = weight;
    private double Volume { get; set; } = volume;
    private decimal Price { get; set; } = price;

    private CupPurpose _cupPurpose { get; set; }

    public CupPurpose CreateCupPurpose()
    {
        _cupPurpose = CupPurpose.CreateCupPurpose(this);
        return _cupPurpose;
    }

    public string GetName()
    {
        return Name;
    }

    public double GetWeight()
    {
        return Weight;
    }

    public double GetVolume()
    {
        return Volume;
    }


    public decimal GetPrice()
    {
        return Price;
    }

    public decimal SetPrice(decimal price)
    {
        return Price = price;
    }

    public CupPurpose GetCupPurpose()
    {
        return _cupPurpose;
    }

    public override string ToString()
    {
        return $"Name: {Name}, Weight: {Weight}, Volume: {Volume}";
    }

    public abstract void Drink();
}