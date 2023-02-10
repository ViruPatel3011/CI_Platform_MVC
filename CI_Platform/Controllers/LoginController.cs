using Microsoft.AspNetCore.Mvc;

namespace CI_Platform.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
