using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BDRadio.Models;
using DBRadio.Data;

namespace DBRadio.Pages.ZapisiP
{
    public class DetailsModel : PageModel
    {
        private readonly DBRadio.Data.DBRadioContext _context;

        public DetailsModel(DBRadio.Data.DBRadioContext context)
        {
            _context = context;
        }

        public Zapisi Zapisi { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Zapisi = await _context.Zapisi.FirstOrDefaultAsync(m => m.ID == id);

            if (Zapisi == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
