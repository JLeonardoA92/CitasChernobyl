using Microsoft.AspNetCore.Mvc;

namespace CitasChernobyl.Controllers
{
    public class RegistroController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
