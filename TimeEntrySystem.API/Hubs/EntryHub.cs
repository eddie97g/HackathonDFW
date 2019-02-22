using Microsoft.AspNetCore.SignalR;

namespace TimeEntrySystem.API.Hubs
{
    public class EntryHub: Hub
    {
        public void Entry()
        {
            //you're going to configure your client app to listen for this
            Clients.All.SendAsync("sendToAll");
        }
    }
}