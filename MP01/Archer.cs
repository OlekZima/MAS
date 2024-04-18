using System.Text.Json;
using System.Text.Json.Serialization;

namespace MP01;

public class Archer
{
    /// <summary>
    /// Ekstensja
    /// </summary>
    private static List<Archer> Archers = [];

    /// <summary>
    /// Identyfikator
    /// </summary>
    private static int _idCounter = 1;

    public int Id { get; }


    /// <summary>
    /// Atrybut powtarzalny
    /// </summary> 
    public List<string> Names { get; set; } = [];


    /// <summary>
    /// Atrybut złożony
    /// </summary>
    [JsonInclude]
    private List<Arrow> Arrows { get; set; } = [];

    [JsonInclude] private DateOnly DateOfJoining { get; set; }


    /// <summary>
    /// Atrybut opcjonalny
    /// </summary>
    public string? PhoneNumber { get; set; }


    /// <summary>
    /// Atrybut klasowy
    /// </summary>
    public static string Club { get; set; } = "LKS Łucznik Żywiec";


    private const int MinArrows = 12;

    /// <summary>
    /// Atrybut pochodny
    /// </summary>
    /// <param name="minArrows"></param>
    /// <returns></returns>
    public bool HasEnoughArrows
    {
        get { return Arrows.Count >= MinArrows; }
    }

    public int HowManyDaysInClub
    {
        get
        {
            DateTime dateTimeOfJoining = new DateTime(DateOfJoining.Year, DateOfJoining.Month, DateOfJoining.Day);
            return (DateTime.Today - dateTimeOfJoining).Days;
        }
    }


    public Archer()
    {
        Id = _idCounter++;
        Arrows = new List<Arrow>();
        Archers.Add(this);
    }

    public Archer(List<Arrow> arrows, DateOnly dateOfJoining)
    {
        Arrows = arrows;
        DateOfJoining = dateOfJoining;

        Id = _idCounter++;
        Arrows = new List<Arrow>();
        Archers.Add(this);
    }

    public static void SerializeArchers()
    {
        try
        {
            var serializerOptions = new JsonSerializerOptions() { IncludeFields = true };
            var serializedString = JsonSerializer.Serialize(Archers, serializerOptions);
            File.WriteAllText("archers.json", serializedString);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public static void DeserializeArchers()
    {
        try
        {
            var jsonString = File.ReadAllText("archers.json");
            if (string.IsNullOrEmpty(jsonString))
            {
                Console.WriteLine("Plik JSON jest pusty\nDeserializacja nie powiodła się");
                return;
            }

            var deserializerOptions = new JsonSerializerOptions() { IncludeFields = true };
            var deserializedArchers = JsonSerializer.Deserialize<List<Archer>>(jsonString, deserializerOptions);
            if (deserializedArchers != null)
            {
                Archers = deserializedArchers;
            }

            if (Archers.Count >= 1)
            {
                Console.WriteLine("Deserializacja powiodła się");
                return;
            }

            Console.WriteLine("Deserializacja nie powiodła się");
            Console.WriteLine("Brak łuczników w pliku JSON");
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public static IReadOnlyList<Archer> GetArchers()
    {
        return Archers.AsReadOnly();
    }

    public override string ToString()
    {
        var phoneNumber = "";
        var names = string.Join(" ", Names);
        if (string.IsNullOrEmpty(PhoneNumber))
        {
            phoneNumber = "Brak numeru telefonu";
        }
        else
        {
            phoneNumber = PhoneNumber;
        }

        return
            $"Archer: {names}, {phoneNumber}, {Arrows.Count} arrows, {DateOfJoining} - {Club}, {HowManyDaysInClub} days in club";
    }
}