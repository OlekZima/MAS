namespace MP4;

public class Coach
{
    private ArcherGroup _memberArchers;
    private ArcherGroup _trainedArchers;

    public void AddMemberArcher(Archer archer)
    {
        _memberArchers.AddArcher(archer);
    }

    public void RemoveMemberArcher(Archer archer)
    {
        if (_trainedArchers.Contains(archer))
        {
            Console.WriteLine("Cannot remove an archer who is being trained.\n");
            return;
        }
        _memberArchers.RemoveArcher(archer);
    }

    public void AddTrainedArcher(Archer archer)
    {
        if (!_memberArchers.Contains(archer))
        {
            Console.WriteLine("Cannot train an archer who is not a member.\n");
            return;
        }
        _trainedArchers.AddArcher(archer);
    }

    public void RemoveTrainedArcher(Archer archer)
    {
        _trainedArchers.RemoveArcher(archer);
    }

    public List<Archer> GetMemberArchers()
    {
        return _memberArchers.GetArchers();
    }

    public List<Archer> GetTrainedArchers()
    {
        return _trainedArchers.GetArchers();
    }
}