namespace MP03.Overlapping;

public class BomberAircraft(int numberOfBombs, int cargoCapacity)
{
    private int NumberOfBombs { get; set; } = numberOfBombs;
    private int CargoCapacity { get; set; } = cargoCapacity;

    public int GetNumberOfBombs()
    {
        return NumberOfBombs;
    }

    public int GetCargoCapacity()
    {
        return CargoCapacity;
    }

    public override string ToString()
    {
        return $"Bomber aircraft with {NumberOfBombs} bombs and cargo capacity of {CargoCapacity} kg";
    }
}