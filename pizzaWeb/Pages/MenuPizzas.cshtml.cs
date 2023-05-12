using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using pizzaWeb.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pizzaWeb.Pages
{
    public class MenuPizzasModel : PageModel
    {
        private readonly pizzaWeb.Data.DataContext _context;
        public MenuPizzasModel(pizzaWeb.Data.DataContext context)
        {
            _context = context;
        }
        public IList<Pizza> Pizza { get; set; }

        public async Task OnGetAsync()
        {
            Pizza = await _context.Pizzas.ToListAsync();
            Pizza = Pizza.OrderBy(p => p.prix).ToList();
        }
    }
}
