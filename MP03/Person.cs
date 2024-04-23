namespace MP03;

public abstract class Person
{
    private int _idCounter = 1;
    public int Id;
    public List<string> Names = new();

    public Person(List<string> names, DateOnly dateOfBirth, DateOnly dateOfJoining)
    {
        Names = names;
        DateOfBirth = dateOfBirth;
        DateOfJoining = dateOfJoining;
        Id = _idCounter;
        _idCounter++;
    }

    public DateOnly DateOfBirth { get; }
    public DateOnly DateOfJoining;

    public abstract AccessLevel GetAccessLevel();
    public abstract float GetIncome();

    public abstract void Train(Archer? archer = null!, Coach? coach = null!);

    public override string ToString()
    {
        return $"Id: {Id}, Person {string.Join(" ", Names)}, born {DateOfBirth}, joined the club {DateOfJoining}";
    }
}