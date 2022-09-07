using WebAppDETAug2022.Models;

namespace WebAppDETAug2022.Services
{
    public class TicketService
    {
        static List<Tickets> ticket { get; }
       
        static TicketService()
        {
            ticket = new List<Tickets>
            {
            new Tickets{ Category="PlatinumPlus",price=5000,MaxLimit=200000},
            new Tickets{Category="Platinum",price=4000,MaxLimit=300000},
            new Tickets{Category="Gold",price=3000,MaxLimit=500000},
            new Tickets{Category="Silver",price=2000,MaxLimit=500000},
            new Tickets{Category="General",price=8000,MaxLimit=100000}
            };
        }

        public static List<Tickets> GetAll() => ticket;

    }
}
