using Microsoft.AspNetCore.Mvc;

namespace AdminUserSignalR.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
