using Microsoft.AspNetCore.Mvc;

namespace Portifolio.Api;

[Route("api/[controller]")]
[ApiController]
public class TestesController : Controller
{
    [HttpGet("GetData")]
    public IActionResult GetData()
    {
        var data = new { nome = "Jorel", idade = "30" };

        return Ok(data);
    }
}
