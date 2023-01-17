using choreScore.Enums;
namespace choreScore.Models;

public class Chore
{
    public Chore(string name, int difficulty, bool done, ChoreLocations location)
    {
        Id = Guid.NewGuid();
        Name = name;
        Difficulty = difficulty;
        Done = done;
        Location = location;
    }

    // public Guid Id { get; set; }
    public Guid Id { get; set; }
    public string Name { get; set; }
    public int Difficulty { get; set; }
    public bool Done { get; set; }
    public ChoreLocations Location { get; set; }

}
