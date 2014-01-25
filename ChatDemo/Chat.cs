using Microsoft.AspNet.SignalR;

namespace ChatDemo
{
    public class Chat : Hub
    {
        public void Send(string platform, string message)
        {
            Clients.All.messageReceived(platform, message);
        }
    }
}