using Microsoft.AspNetCore.Mvc;
 
public class HomeController : Controller
{
    [Route("home/index")]
    public IActionResult Index()
    {
        return Ok("Hello World from a controller");
    }

    [Route("home/json/{username}")]
    public IActionResult Json(string username){
        var greeting = new Greeting{ Username = username };
        return Ok(greeting);
    }
}