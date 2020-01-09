using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ECom.Data;
using ECom.Models;
using ECom.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ECom.Pages.Show
{
    public class indexModel : PageModel
    {
        private readonly IInventory _context;
        public indexModel(IInventory context)
        {
            _context = context;
        }
       public IEnumerable<Product> Products { get; set; }

        public async Task OnGet()
        {
            Products = await _context.GetProductsAsync();
        }
    }
}