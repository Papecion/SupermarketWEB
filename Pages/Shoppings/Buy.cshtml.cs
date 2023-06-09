using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SupermarketWEB.Data;
using SupermarketWEB.Models;

namespace SupermarketWEB.Pages.Shoppings
{
    public class BuyModel : PageModel
    {
        private readonly SupermarketContext _context;

        public BuyModel(SupermarketContext context)
        {
            _context = context;
        }

        public IList<Product> Products { get; set; }

        public async Task OnGetAsync(string searchString)
        {



            var products = from p in _context.Products
                           select p;

            if (!String.IsNullOrEmpty(searchString))
            {
                products = products.Where(p => p.Name.Contains(searchString));
            }

            Products = await products.ToListAsync();


        }
    }
}
