using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace asp.net_signalr.Hubs
{
    public class ChatHub: Hub
    {
        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
    }
}
