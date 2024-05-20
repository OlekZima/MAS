namespace MP01;

public enum ArrowheadMaterial
{
    Wolfram,
    Aluminium,
    StainlessSteel
}

public class Arrow
{
    private static int _idCounter = 1;
    public int Id;

    public Arrow()
    {
        Id = _idCounter++;
    }

    public required string Material { get; set; }
    public required double Length { get; set; }
    public required ArrowheadMaterial ArrowheadMaterial { get; set; }

    public override string ToString()
    {
        return $"Arrow: {Material}, {Length} cm, {ArrowheadMaterial}";
    }
}