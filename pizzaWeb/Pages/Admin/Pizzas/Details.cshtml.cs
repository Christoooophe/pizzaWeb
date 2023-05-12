using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using pizzaWeb.Data;
using pizzaWeb.Models;

namespace pizzaWeb.Pages.Admin.Pizzas
{
    public class DetailsModel : PageModel
    {
        private readonly pizzaWeb.Data.DataContext _context;

        public DetailsModel(pizzaWeb.Data.DataContext context)
        {
            _context = context;
        }

        public Pizza Pizza { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Pizza = await _context.Pizzas.FirstOrDefaultAsync(m => m.PizzaId == id);

            if (Pizza == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
