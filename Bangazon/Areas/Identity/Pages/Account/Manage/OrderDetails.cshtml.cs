using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bangazon.Data;
using Bangazon.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Bangazon.Areas.Identity.Pages.Account.Manage
{
    public class OrderDetailsModel : PageModel
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ApplicationDbContext _context;

        public OrderDetailsModel(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        public void OnGet()
        {
        }

        [BindProperty(SupportsGet=true)]
        public int Id { get; set; }

        public Order order
        {
            get
            {
                var results = _context.Order
                     .Where(o => o.OrderId == Id)
                     .Include(o => o.PaymentType)
                     .Include(o => o.OrderProducts)
                       .ThenInclude(op => op.Product);
                return results.FirstOrDefault();

            }
        }
    }
}