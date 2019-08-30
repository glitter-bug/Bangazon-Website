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
using Microsoft.AspNetCore.Mvc.Rendering;


namespace Bangazon.Areas.Identity.Pages.Account.Manage
{
    public class ProductReviewsModel : PageModel
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ApplicationDbContext _context;

        public ProductReviewsModel(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        [BindProperty(SupportsGet = true)]
        public int Id { get; set; }

        public Product product
        {
            get
            {
                var result = _context.Product
                    .Where(p => p.ProductId == Id);

                return result.FirstOrDefault();
            }
        }

        [BindProperty]
        public ProductReview review { get; set; }

        public IActionResult OnGet()
        {
        

            return Page();
        }

        public async Task<IActionResult> OnPost()
        {
            review.UserId = _userManager.GetUserId(User);
            review.ProductId = Id;
            var checkForReview = _context.ProductReview
                .Where(pr => pr.ProductId == Id && pr.UserId == _userManager.GetUserId(User));
            if(checkForReview != null)
            {
                _context.Update(review);
            }
            else
            {
                _context.Add(review);
            }
            await _context.SaveChangesAsync();
            return Redirect(ManageNavPages.OrderHistory);
        }
       
    }
}