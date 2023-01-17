
namespace choreScore.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ChoresController : ControllerBase
{
    private readonly ChoresService _choresService;
    public ChoresController(ChoresService choresService)
    {
        this._choresService = choresService;
    }

    [HttpGet]
    public ActionResult<List<Chore>> GetAll()
    {
        try
        {
            List<Chore> chores = _choresService.GetAll();
            return Ok(chores);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }

    [HttpPost]
    public ActionResult<Chore> Create([FromBody] Chore choreData)
    {
        try
        {
            Chore chore = _choresService.Create(choreData);
            return Ok(chore);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }

    [HttpDelete("{id}")]
    public ActionResult<string> Remove(Guid id)
    {
        try
        {
            string message = _choresService.Remove(id);
            return Ok(message);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }

}
