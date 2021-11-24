using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace backend.Hubs
{
    public class TodoHub : Hub
    {
        public override async Task OnConnectedAsync()
        {
            await base.OnConnectedAsync();
            await Get();
        }

        public async Task Add(string msg)
        {
            await Clients.Caller.SendAsync("Add", msg);
        }

        public async Task Get()
        {
            var tasks = new List<string>
            {
                "Тест",
                "Выпить",
                "Сделать"
            };
            await Clients.Caller.SendAsync("Receive", tasks);
        }
    }
}