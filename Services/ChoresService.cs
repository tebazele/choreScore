
namespace choreScore.Services;

public class ChoresService
{
    private readonly ChoresRepository _repo;

    public ChoresService(ChoresRepository repo)
    {
        _repo = repo;
    }

    internal List<Chore> GetAll()
    {
        List<Chore> chores = _repo.GetAll();
        return chores;
    }

    internal Chore Create(Chore choreData)
    {
        Chore newChore = _repo.Create(choreData);
        return newChore;
    }
}
