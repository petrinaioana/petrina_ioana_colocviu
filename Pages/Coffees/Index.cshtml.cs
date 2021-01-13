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
    public class IndexModel : PageModel
    {
        private readonly petrina_ioana_colocviu.Data.petrina_ioana_colocviuContext _context;

        public IndexModel(petrina_ioana_colocviu.Data.petrina_ioana_colocviuContext context)
        {
            _context = context;
        }

        public IList<Coffee> Coffee { get;set; }

        public async Task OnGetAsync()
        {
            Coffee = await _context.Coffee.ToListAsync();
        }
    }
}
