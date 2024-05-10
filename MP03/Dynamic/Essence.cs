namespace MP03.Dynamic;

public abstract class Essence(DateOnly date, string cause)
{
    private Life? Life { get; set; }
    private Death? Death { get; set; }

    private string Cause { get; set; } = cause;
    private DateOnly Date { get; set; } = date;

    public DateOnly GetDate() => Date;
    public string GetCause() => Cause;
    public Life? GetLife() => Life;
    public Death? GetDeath() => Death;

    public void SetDate(DateOnly date) => Date = date;
    public void SetCause(string cause) => Cause = cause;
    public void SetLife(Life? life) => Life = life;
    public void SetDeath(Death? death) => Death = death;

    public override string ToString() => $"Date: {Date}, Cause: {Cause}";

    public void CheckXor()
    {
        if (Life != null && Death != null)
            throw new ArgumentException("Essence cannot have both Life and Death");
    }
}