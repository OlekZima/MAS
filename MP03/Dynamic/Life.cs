namespace MP03.Dynamic;

public class Life : Essence
{
    private Essence Essence { get; set; }
    private int ApproximatedAge { get; set; }

    public Life(int approximatedAge, DateOnly date, string cause) : base(date, cause)
    {
        ApproximatedAge = approximatedAge;
    }

    public Life(Essence essence, int approximatedAge) : base(essence.GetDate(), essence.GetCause())
    {
        ApproximatedAge = approximatedAge;
        Essence = essence;
        essence.SetDeath(null);
        essence.SetLife(this);

        essence.CheckXor();
    }

    public override string ToString() =>
        $"{GetType().Name}, {base.ToString()}, Approximated Age: {ApproximatedAge}";
}