using DataAccessLayer;
using DataAccessLayer.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace KE03_INTDEV_SE_1_Base.Pages
{
    public class OrderHistoryModelPage : PageModel
    {
        private readonly MatrixIncDbContext _context;

        private const int ActiveCustomerId = 1;

        public OrderHistoryModelPage(MatrixIncDbContext context)
        {
            _context = context;
        }

        public List<Order> Orders { get; set; } = new();

        public void OnGet()
        {
            Orders = _context.Orders
                .Include(o => o.Customer)
                .Include(o => o.Products)
                .Where(o => o.Customer.Id == ActiveCustomerId)
                .OrderByDescending(o => o.OrderDate)
                .ToList();
        }
    }
}
