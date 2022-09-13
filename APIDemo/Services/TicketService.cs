using APIDemo.Models;

namespace APIDemo.Services
{
    public class TicketService
    {
        static List<Ticket> Tickets { get; }
        static TicketService()
        {
            Tickets = new List<Ticket>
            {
            new Ticket{ ID=1,BookedFor="PlatinumPlus",Price=5000,Qty=200000},
            new Ticket{ID=11,BookedFor="Platinum",Price=4000,Qty=300000},
            new Ticket { ID = 12, BookedFor = "Gold", Price = 3000, Qty = 500000 },
            new Ticket { ID = 13, BookedFor = "Silver", Price = 2000, Qty = 500000 },
            new Ticket { ID = 14, BookedFor = "General", Price = 8000, Qty = 100000 }
            };
        }

        public static List<Ticket> GetAll() => Tickets;

        public static Ticket Get(int id)
        {
            Ticket ticket = Tickets.FirstOrDefault(x=>x.ID==id);
            return ticket;
        }
    }
}
