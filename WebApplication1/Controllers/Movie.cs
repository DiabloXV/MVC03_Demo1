using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class Movie : Controller
    {
        public IActionResult Index()
        {
            return RedirectToAction(nameof(GetMovie), new { id = 10 });
        }

        public IActionResult GetMovie(int id)
        {
            return Content($"Movie with id = {id}");
        }

        

    }
}
