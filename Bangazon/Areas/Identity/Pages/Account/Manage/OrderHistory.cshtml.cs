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
    public class OrderHistoryModel : PageModel
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ApplicationDbContext _context;

        public OrderHistoryModel(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public List<Order> Orders
        {
             get 
            {
                  return  _context.Order
                      .Where(o => o.UserId == _userManager.GetUserId(User))
                      .Include(o => o.PaymentType)
                      .Include(o => o.OrderProducts)
                        .ThenInclude(op => op.Product)
                      .OrderBy(o => o.DateCompleted)
                      .ToList();
            }
        }
        public void OnGet()
        {

        }
    }
}