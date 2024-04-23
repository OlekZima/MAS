namespace MP03;

public class Archer : Person
{
    public Archer(List<string> names, DateOnly dateOfBirth, DateOnly dateOfJoining, float scholarship,
        AccessLevel accessLevel) : base(names,
        dateOfBirth,
        dateOfJoining)
    {
        Scholarship = scholarship;
        AccessLevel = accessLevel;
    }

    public float Scholarship { get; set; }

    public AccessLevel AccessLevel { get; set; }

    public float GetScholarship()
    {
        return GetIncome();
    }

    public override AccessLevel GetAccessLevel()
    {
        return AccessLevel;
    }

    public override float GetIncome()
    {
        return Scholarship;
    }

    public override void Train(Archer? archer = null, Coach? coach = null)
    {
        if (coach == null && archer != null)
        {
            Console.WriteLine($"Coach is training {archer}");
        }
        else if (coach != null && archer == null)
        {
            Console.WriteLine($"Archer {this} is being trained by {coach}");
        }
    }
}