namespace MP03;

public abstract class Person
{
    private static int _idCounter = 1;
    private readonly int _id;
    public List<string> Names;

    public Person(List<string> names, DateOnly dateOfBirth, DateOnly dateOfJoining)
    {
        Names = names;
        DateOfBirth = dateOfBirth;
        DateOfJoining = dateOfJoining;
        _id = _idCounter;
        _idCounter++;
    }

    public DateOnly DateOfBirth { get; }
    public DateOnly DateOfJoining;

    public abstract AccessLevel GetAccessLevel();
    public abstract float GetIncome();

    public int GetId()
    {
        return _id;
    }
    
    public abstract void Train(Archer? archer = null, Coach? coach = null);

    public override string ToString()
    {
        return $"Id: {_id}, Person {string.Join(" ", Names)}, born {DateOfBirth}, joined the club {DateOfJoining}";
    }
}