using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
