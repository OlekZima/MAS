namespace MP03.Overlapping;

public class FighterJetAircraft(int numberOfMissiles, int maxSpeed)
{
    private int NumberOfMissiles { get; set; } = numberOfMissiles;
    private int MaxSpeed { get; set; } = maxSpeed;

    public int GetNumberOfMissiles()
    {
        return NumberOfMissiles;
    }

    public int GetMaxSpeed()
    {
        return MaxSpeed;
    }

    public override string ToString()
    {
        return $"Fighter jet with {NumberOfMissiles} missiles and max speed of {MaxSpeed} km/h";
    }
}