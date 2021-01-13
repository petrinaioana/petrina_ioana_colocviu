using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using petrina_ioana_colocviu.Data;
using petrina_ioana_colocviu.Models;

namespace petrina_ioana_colocviu.Pages.Coffees
{
    public class DeleteModel : PageModel
    {
        private readonly petrina_ioana_colocviu.Data.petrina_ioana_colocviuContext _context;

        public DeleteModel(petrina_ioana_colocviu.Data.petrina_ioana_colocviuContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Coffee Coffee { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Coffee = await _context.Coffee.FirstOrDefaultAsync(m => m.ID == id);

            if (Coffee == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Coffee = await _context.Coffee.FindAsync(id);

            if (Coffee != null)
            {
                _context.Coffee.Remove(Coffee);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
