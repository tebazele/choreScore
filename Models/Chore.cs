// using choreScore.Enums;
namespace choreScore.Models;

public class Chore
{
    public Chore(int id, string name, int difficulty, bool done, string location)
    {
        Id = id;
        Name = name;
        Difficulty = difficulty;
        Done = done;
        Location = location;
    }

    // public Guid Id { get; set; }
    public int Id { get; set; }
    public string Name { get; set; }
    public int Difficulty { get; set; }
    public bool Done { get; set; }
    public string Location { get; set; }

}
