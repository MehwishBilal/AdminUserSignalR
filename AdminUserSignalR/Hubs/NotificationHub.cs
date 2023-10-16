using Microsoft.AspNetCore.SignalR;

namespace AdminUserSignalR.Hubs
{
    public class NotificationHub : Hub
    {
        public async Task SendMessage(string msg)
        {
            await Clients.All.SendAsync("ReceiveMessage", msg);
        }

    }
}
