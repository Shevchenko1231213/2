using Microsoft.AspNetCore.Mvc;

namespace Lab2.Controllers
{
    public class BaseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
