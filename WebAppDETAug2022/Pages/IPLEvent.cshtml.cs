using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebAppDETAug2022.Models;

namespace WebAppDETAug2022.Pages
{
    public class IPLEventModel : PageModel
    {
        public List<Tickets> Tickets { get; set; }
        public void OnGet()
        {
            Tickets = new List<Tickets>
        {
            new Tickets{Category="platinumPlus", price=5000, MaxLimit=200000 },
            new Tickets{Category="platinum", price=4000, MaxLimit=300000 },
            new Tickets{Category="Gold", price=3000, MaxLimit=500000 },
            new Tickets{Category="Silver", price=2000, MaxLimit=500000 },
            new Tickets{Category="General", price=800, MaxLimit=100000 },


        };
        }
    }
}
