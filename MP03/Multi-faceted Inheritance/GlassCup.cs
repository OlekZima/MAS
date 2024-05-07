namespace MP03.Multi_faceted_Inheritance;

public class GlassCup(string name, double weight, double volume, decimal price)
    : Cup(name, weight, volume, price)
{

    public override void Drink()
    {
        Console.WriteLine("Drinking from glass cup");
    }

    public override string ToString()
    {
        return base.ToString() + ", Glass Cup";
    }

    
}