using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Sas_Bogdan_Lab2.Data;
using Sas_Bogdan_Lab2.Models;
using Sas_Bogdan_Lab2.Models.viewmodels;

namespace Sas_Bogdan_Lab2.Pages.Categories
{
    public class IndexModel : PageModel
    {
        private readonly Sas_Bogdan_Lab2.Data.Sas_Bogdan_Lab2Context _context;

        public IndexModel(Sas_Bogdan_Lab2.Data.Sas_Bogdan_Lab2Context context)
        {
            _context = context;
        }

        
        public CategoryIndexData CategoryData { get; set; }
        public int CategoryID { get; set; }
        public int BookID { get; set; }
         public int BookCategories { get; set; }
        

        public IList<Category> Category { get;set; } = default!;

        public async Task OnGetAsync(int? id, int? bookID)
        {
            CategoryData = new CategoryIndexData();
            CategoryData.Categories = await _context.Category
            
            .Include(i => i.BookCategories)
            .ThenInclude(i => i.Book)
            .ThenInclude(c => c.Author)
            .OrderBy(i => i.CategoryName)
            .ToListAsync();
            if (id != null)
            {
                CategoryID = id.Value;
                Category category = CategoryData.Categories
                .Where(i => i.ID == id.Value).Single();
                CategoryData.BookCategories = category.BookCategories;
            }
        }
    }
}
