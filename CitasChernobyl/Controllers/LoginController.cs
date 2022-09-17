using Microsoft.AspNetCore.Mvc;

namespace CitasChernobyl.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
