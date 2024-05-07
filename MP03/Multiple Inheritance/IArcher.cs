namespace MP03.Multiple_Inheritance;

public interface IArcher
{
    public float GetScholarship();
    
    public float GetIncome();
    
    public void Train(Archer? archer = null, Coach? coach = null);
    
    
}