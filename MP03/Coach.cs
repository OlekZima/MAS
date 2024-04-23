namespace MP03;

public class Coach : Person
{
    public Coach(List<string> names, DateOnly dateOfBirth, DateOnly dateOfJoining, float salary,
        AccessLevel accessLevel) : base(names,
        dateOfBirth,
        dateOfJoining)
    {
        Salary = salary;
        AccessLevel = accessLevel;
    }

    public float Salary { get; set; }

    public AccessLevel AccessLevel { get; set; }

    public override float GetIncome()
    {
        return GetSalary();
    }
    
    public override void Train(Archer? archer = null, Coach? coach = null)
    {
        if (coach == null && archer != null)
        {
            Console.WriteLine($"Coach {this} is training {archer}");
        }
        else if (coach != null && archer == null)
        {
            Console.WriteLine($"Archer {this} is being trained by {coach}");
        }
    }

    public float GetSalary()
    {
        return Salary;
    }

    public override AccessLevel GetAccessLevel()
    {
        return AccessLevel;
    }
}