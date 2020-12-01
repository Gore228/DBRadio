using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BDRadio.Models;
using DBRadio.Data;

namespace DBRadio.Pages.SotrudnikiP
{
    public class EditModel : PageModel
    {
        private readonly DBRadio.Data.DBRadioContext _context;

        public EditModel(DBRadio.Data.DBRadioContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Sotrudniki Sotrudniki { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Sotrudniki = await _context.Sotrudniki.FirstOrDefaultAsync(m => m.ID == id);

            if (Sotrudniki == null)
            {
                return NotFound();
            }
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Sotrudniki).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SotrudnikiExists(Sotrudniki.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool SotrudnikiExists(long id)
        {
            return _context.Sotrudniki.Any(e => e.ID == id);
        }
    }
}
