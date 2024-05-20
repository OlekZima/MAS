namespace MP03.Multiple_Inheritance;

public class ArcherCoach(
    List<string> names,
    DateOnly dateOfBirth,
    DateOnly dateOfJoining,
    float salary,
    AccessLevel accessLevel,
    Archer Archer)
    : Coach(names, dateOfBirth, dateOfJoining, salary, accessLevel), IArcher
{
    public float GetScholarship()
    {
        return Archer.GetIncome();
    }

    public override float GetIncome()
    {
        return GetSalary() + GetScholarship();
    }

    public override AccessLevel GetAccessLevel()
    {
        return AccessLevel;
    }

    
}