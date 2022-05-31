using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace BTMS.Data.Hubs
{
    public class BookingNotifyHub:Hub
    {
        public async Task BookingNotify(BookingMessage message)
        {
            await Clients.All.SendAsync("seatBooked", message);
        }
    }
}
