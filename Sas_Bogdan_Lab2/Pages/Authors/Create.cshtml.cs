using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Sas_Bogdan_Lab2.Data;
using Sas_Bogdan_Lab2.Models;

namespace Sas_Bogdan_Lab2.Pages.Authors
{
    public class CreateModel : PageModel
    {
        private readonly Sas_Bogdan_Lab2.Data.Sas_Bogdan_Lab2Context _context;

        public CreateModel(Sas_Bogdan_Lab2.Data.Sas_Bogdan_Lab2Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Author Author { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Author.Add(Author);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
