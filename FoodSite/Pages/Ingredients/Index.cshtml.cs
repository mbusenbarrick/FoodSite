using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FoodSite.Models;

namespace FoodSite.Pages.Ingredients
{
    public class IndexModel : PageModel
    {
        private readonly FoodSite.Models.IngredientContext _context;

        public IndexModel(FoodSite.Models.IngredientContext context)
        {
            _context = context;
        }

        public IList<Ingredient> Ingredient { get;set; }

        public async Task OnGetAsync()
        {
            Ingredient = await _context.Ingredient.ToListAsync();
        }
    }
}
