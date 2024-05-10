namespace MP03.Dynamic;

public class Death : Essence
{
    private Essence Essence { get; set; }
    private int Age { get; set; }

    public Essence GetEssence() => Essence;
    public int GetAge() => Age;

    public void SetEssence(Essence essence) => Essence = essence;

    public Death(int age, DateOnly date, string cause) : base(date, cause)
    {
        Age = age;
    }

    public Death(Essence essence, int age) : base(essence.GetDate(), essence.GetCause())
    {
        Age = age;
        Essence = essence;
        essence.SetLife(null);
        essence.SetDeath(this);

        essence.CheckXor();
    }

    public override string ToString() => $"{GetType().Name}, {base.ToString()}, Age: {Age}";
}