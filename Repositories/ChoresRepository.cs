
namespace choreScore.Repositories;

public class ChoresRepository
{
    private List<Chore> choreDb;

    public ChoresRepository()
    {
        this.choreDb = new List<Chore>()
        {
            new Chore("Dishes", 8, false, Enums.ChoreLocations.Kitchen),
            new Chore("Laundry", 6, false, Enums.ChoreLocations.LaundryRoom),
            new Chore("Get Mail", 1, true, Enums.ChoreLocations.LivingRoom),
            new Chore("Vacuum", 10, false, Enums.ChoreLocations.KidsRooms),
            new Chore("Feed Bunnies", 3, false, Enums.ChoreLocations.LivingRoom)
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

    internal string Remove(Guid id)
    {
        Chore choreToRemove = choreDb.Find(ch => ch.Id == id);
        bool result = choreDb.Remove(choreToRemove);
        if (result)
        {
            return $"{choreToRemove.Name} was removed from db";
        }
        return "no chore to delete";
    }
}
