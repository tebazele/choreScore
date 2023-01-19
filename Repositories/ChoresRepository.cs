
namespace choreScore.Repositories;

public class ChoresRepository
{
    private readonly IDbConnection _db;

    public ChoresRepository(IDbConnection db)
    {
        _db = db;
    }

    internal List<Chore> GetAll()
    {
        string sql = @"
        SELECT 
        chores.*,
        accounts.*
        FROM chores
        JOIN accounts ON accounts.id = chores.creatorId;
        ";
        List<Chore> chores = _db.Query<Chore, Account, Chore>(sql, (chore, account) =>
        {
            chore.Creator = account;
            return chore;
        }).ToList();

        return chores;

    }

    internal Chore Create(Chore choreData)
    {
        string sql = @"
        INSERT INTO chores
        (name, difficulty, done, location, creatorId)
        VALUES
        (@name, @difficulty, @done, @location, @creatorId);
        SELECT LAST_INSERT_ID();
        ";
        int id = _db.ExecuteScalar<int>(sql, choreData);
        choreData.Id = id;
        return choreData;
    }

    internal string Remove(int id)
    {
        string sql = @"
        DELETE FROM chores
        WHERE id = @id;
        ";
        _db.Execute(sql, new { id });
        return "That chore has been deleted";
    }

    internal Chore GetOne(int id)
    {
        string sql = @"
        SELECT 
        chores.*,
        accounts.*
        FROM chores
        JOIN accounts ON accounts.id = chores.creatorId
        WHERE chores.id = @id;
        ";
        return _db.Query<Chore, Account, Chore>(sql, (chore, account) =>
        {
            chore.Creator = account;
            return chore;
        }, new { id }).FirstOrDefault();

    }
}
