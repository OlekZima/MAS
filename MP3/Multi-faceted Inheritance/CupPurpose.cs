namespace MP03.Multi_faceted_Inheritance;

public class CupPurpose
{
    private Cup Cup { get; set; }

    private protected CupPurpose(Cup cup)
    {
        Cup = cup;
    }

    public static CupPurpose CreateCupPurpose(Cup cup)
    {
        return new CupPurpose(cup);
    }

    public Cup GetCup()
    {
        return Cup;
    }
    
    public override string ToString()
    {
        return Cup.ToString();
    }
}

public class CupPurposeKitchen : CupPurpose
{
    private bool IsDishwasherSafe { get; set; }

    private CupPurposeKitchen(Cup cup, bool isDishwasherSafe) : base(cup)
    {
        IsDishwasherSafe = isDishwasherSafe;
    }
    
    public static CupPurpose CreateCupPurposeKitchen(Cup cup, bool isDishwasherSafe)
    {
        return new CupPurposeKitchen(cup, isDishwasherSafe);
    }

    public bool GetIsDishwasherSafe()
    {
        return IsDishwasherSafe;
    }

    public void SetIsDishwasherSafe(bool isDishwasherSafe)
    {
        IsDishwasherSafe = isDishwasherSafe;
    }

    public void LoadDishwasher()
    {
        Console.WriteLine(IsDishwasherSafe ? "Loading dishwasher" : "This cup is not dishwasher safe");
    }

    public override string ToString()
    {
        return base.ToString() + $", Is dishwasher safe: {IsDishwasherSafe}";
    }
}

public class CupPurposeRestaurant : CupPurpose
{
    private bool IsClean { get; set; }

    private CupPurposeRestaurant(Cup cup, bool isClean) : base(cup)
    {
        IsClean = isClean;
    }
    
    public static CupPurpose CreateCupPurposeRestaurant(Cup cup, bool isClean)
    {
        return new CupPurposeRestaurant(cup, isClean);
    }

    public bool GetIsClean()
    {
        return IsClean;
    }

    public void SetIsClean(bool isClean)
    {
        IsClean = isClean;
    }

    public void Serve()
    {
        Console.WriteLine(IsClean ? "Serving" : "This cup is not clean");
    }
    
    public override string ToString()
    {
        return base.ToString() + $", Is clean: {IsClean}";
    }
}