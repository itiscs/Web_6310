using Microsoft.AspNetCore.SignalR;

namespace ShapeAppSignalR.Hubs
{
    public class ShapeHub:Hub
    {
        public async Task MoveShape(int x, int y)
        {
            await Clients.Others.SendAsync("shapeMoved", x, y);
        }
    }
}
