using Microsoft.AspNetCore.Mvc;

namespace TimeDisplay.Controllers
{
    public class TimeDisplayController : Controller
    {
        [HttpGet("")]
        public ViewResult Index()
        {
            return View();
        }
    }
}