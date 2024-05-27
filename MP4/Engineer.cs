namespace MP4;

public class Engineer
{
    private List<Bow> Bows { get; set; } = [];

    private Dictionary<Archer, Bow> BowsArchers { get; set; } = new();

    public void AddBow(Bow bow, Bow temporaryBow)
    {
        var bowsUsers = bow.GetUsers();

        foreach (var user in bowsUsers)
        {
            BowsArchers[user] = bow;
            user.RemoveBow();
            user.SetBow(temporaryBow);
        }


        if (Bows.Contains(bow))
        {
            Console.WriteLine("\nThis bow is already assigned to this engineer.\nCannot add the same bow twice.\n");
            return;
        }

        Bows.Add(bow);
    }

    public void RemoveBow(Bow bow)
    {
        if (!Bows.Contains(bow))
        {
            Console.WriteLine("\nThis bow is not assigned to this engineer.\nCannot remove the bow.\n");
            return;
        }
        
        var bowsUsers = bow.GetUsers();

        foreach (var user in bowsUsers)
        {
            user.RemoveBow();
            if (!BowsArchers.ContainsKey(user)) continue;
            user.SetBow(bow);
            BowsArchers.Remove(user);
        }

        if (!Bows.Contains(bow))
        {
            Console.WriteLine("\nThis bow is not assigned to this engineer.\nCannot remove the bow.\n");
            return;
        }

        Bows.Remove(bow);
    }
}