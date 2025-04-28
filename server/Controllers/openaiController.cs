namespace openai.Controllers;

// [Authorize]
[ApiController]
[Route("api/[controller]")]
public class openaiController : ControllerBase
{
    [HttpGet]
    public async Task<ActionResult<string>> GetAIMessage()
    {
        return ("It's Working!");
    }

}
