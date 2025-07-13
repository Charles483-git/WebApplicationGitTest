using Microsoft.AspNetCore.Mvc;

namespace WebApplicationGitTest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MyNameController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var result = new { name = "Charles allen" };
            return Ok(result);
        }
    }
}