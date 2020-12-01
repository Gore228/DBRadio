using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BDRadio.Models;
using DBRadio.Data;

namespace DBRadio.Pages.IspolniteliP
{
    public class DeleteModel : PageModel
    {
        private readonly DBRadio.Data.DBRadioContext _context;

        public DeleteModel(DBRadio.Data.DBRadioContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Ispolniteli Ispolniteli { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Ispolniteli = await _context.Ispolniteli.FirstOrDefaultAsync(m => m.ID == id);

            if (Ispolniteli == null)
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

            Ispolniteli = await _context.Ispolniteli.FindAsync(id);

            if (Ispolniteli != null)
            {
                _context.Ispolniteli.Remove(Ispolniteli);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
