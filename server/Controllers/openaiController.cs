namespace openai.Controllers;

[Authorize]
[ApiController]
[Route("[controller]")]
public class openaiController : ControllerBase
{
    [HttpGet]
    public async Task<ActionResult<string>> GetAIMessage()
    {
        return Ok("It's Working!");
    }

}
