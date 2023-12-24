using Microsoft.AspNetCore.Mvc;

namespace DroneCop.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
