using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DBRadio.Data;
using BDRadio.Models;

namespace DBRadio.Pages.Zf.Filtri
{
    public class MusicArchievF : PageModel
    {
        private readonly DBRadio.Data.DBRadioContext _context;

        public MusicArchievF(DBRadio.Data.DBRadioContext context)
        {
            _context = context;
        }

        public IList<Zapisi> Zapisi { get; set; }
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
            Zapisi = await _context.Zapisi.Where(m => m.PerformerID == Ispolniteli.ID).ToListAsync();
            return Page();
        }
    }
}