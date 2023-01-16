
namespace choreScore.Repositories;

public class ChoresRepository
{
    private List<Chore> choreDb;

    public ChoresRepository()
    {
        this.choreDb = new List<Chore>()
        {
            new Chore(1, "Dishes", 8, false, "Kitchen"),
            new Chore(2, "Laundry", 6, false, "LaundryRoom"),
            new Chore(3, "Get Mail", 1, true, "LivingRoom"),
            new Chore(4, "Vacuum", 10, false, "KidsRooms"),
            new Chore(5, "Feed Bunnies", 3, false, "LivingRoom")
        };
    }

    internal List<Chore> GetAll()
    {
        return choreDb;
    }

    internal Chore Create(Chore choreData)
    {
        choreDb.Add(choreData);
        return choreData;
    }
}
