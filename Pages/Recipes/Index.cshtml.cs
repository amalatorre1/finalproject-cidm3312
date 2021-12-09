using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using finalproject_cidm3312.Models;

namespace finalproject_cidm3312.Pages.Recipes
{
    public class IndexModel : PageModel
    {
        private readonly finalproject_cidm3312.Models.RecipeDbContext _context;

        public IndexModel(finalproject_cidm3312.Models.RecipeDbContext context)
        {
            _context = context;
        }

        public IList<Recipe> Recipe { get;set; }

        [BindProperty(SupportsGet = true)]
        public int PageNum {get; set;} = 1;
        public int PageSize {get; set;} = 5;

        [BindProperty(SupportsGet = true)]
        public string CurrentSort {get; set;}

        public async Task OnGetAsync()
        {
            var query = _context.Recipes.Select(r => r);
            switch (CurrentSort)
            {
                case "title_asc":
                    query = query.OrderBy(r => r.Title);
                    break;
                case "title_desc":
                    query = query.OrderByDescending(r => r.Title);
                    break;
            }

            Recipe = await query.Include(r => r.User).Skip((PageNum-1)*PageSize).Take(PageSize).ToListAsync();
            
        }
    }
}
