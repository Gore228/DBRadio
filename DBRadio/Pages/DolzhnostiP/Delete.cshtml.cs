using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BDRadio.Models;
using DBRadio.Data;

namespace DBRadio.Pages.DolzhnostiP
{
    public class DeleteModel : PageModel
    {
        private readonly DBRadio.Data.DBRadioContext _context;

        public DeleteModel(DBRadio.Data.DBRadioContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Dolzhnosti Dolzhnosti { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Dolzhnosti = await _context.Dolzhnosti.FirstOrDefaultAsync(m => m.ID == id);

            if (Dolzhnosti == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Dolzhnosti = await _context.Dolzhnosti.FindAsync(id);

            if (Dolzhnosti != null)
            {
                _context.Dolzhnosti.Remove(Dolzhnosti);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
