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
    public class DetailsModel : PageModel
    {
        private readonly FoodSite.Models.IngredientContext _context;

        public DetailsModel(FoodSite.Models.IngredientContext context)
        {
            _context = context;
        }

        public Ingredient Ingredient { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Ingredient = await _context.Ingredient.SingleOrDefaultAsync(m => m.ID == id);

            if (Ingredient == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
