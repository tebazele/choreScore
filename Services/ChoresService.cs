
namespace choreScore.Services;

public class ChoresService
{
    private readonly ChoresRepository _repo;

    public ChoresService(ChoresRepository repo)
    {
        _repo = repo;
    }

    internal List<Chore> GetAll(string userId)
    {
        List<Chore> chores = _repo.GetAll();
        List<Chore> filteredChores = chores.FindAll(ch => ch.Done == false || ch.CreatorId == userId);
        return filteredChores;
    }

    internal Chore Create(Chore choreData)
    {
        Chore newChore = _repo.Create(choreData);
        return newChore;
    }

    internal string Remove(int id, string userId)
    {
        Chore original = GetOne(id, userId);
        if (original.CreatorId != userId)
        {
            throw new Exception("Nat your chore to delete");
        }
        string message = _repo.Remove(id);
        return message;
    }

    internal Chore GetOne(int id, string userId)
    {
        Chore chore = _repo.GetOne(id);
        if (chore == null)
        {
            throw new Exception("no chore at that id");
        }
        if (chore.Done == true && chore.CreatorId != userId)
        {
            throw new Exception("This chore is already done! Woo hoo!");
        }
        return chore;
    }
}
