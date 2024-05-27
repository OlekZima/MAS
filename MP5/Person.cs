namespace MP5;

public abstract class Person
{
    public int Id { get; set; }
    public List<string> Names { get; set; } = [];
    
    public abstract void Train();
    
    public override string ToString()
    {
        return string.Join(" ", Names) + " " + Id;
    }
}