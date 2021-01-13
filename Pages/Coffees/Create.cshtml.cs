using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using petrina_ioana_colocviu.Data;
using petrina_ioana_colocviu.Models;

namespace petrina_ioana_colocviu.Pages.Coffees
{
    public class CreateModel : PageModel
    {
        private readonly petrina_ioana_colocviu.Data.petrina_ioana_colocviuContext _context;

        public CreateModel(petrina_ioana_colocviu.Data.petrina_ioana_colocviuContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Coffee Coffee { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Coffee.Add(Coffee);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
