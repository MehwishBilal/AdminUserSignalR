using AdminUserSignalR.Hubs;
using AdminUserSignalR.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;

namespace AdminUserSignalR.Controllers
{
    public class AdminController : Controller
    {
        private readonly IHubContext<NotificationHub> _notification;

        public AdminController(IHubContext<NotificationHub> notification)
        {
            _notification = notification;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(Notification model)
        {
            await _notification.Clients.All.SendAsync("ReceiveMessage", model.NotificationMessage);
            return View();
        }
    }
}
