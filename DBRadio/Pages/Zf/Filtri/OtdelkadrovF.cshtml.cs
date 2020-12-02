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
    public class OtdelkadrovF : PageModel
    {
        private readonly DBRadio.Data.DBRadioContext _context;

        public OtdelkadrovF(DBRadio.Data.DBRadioContext context)
        {
            _context = context;
        }

        public IList<Sotrudniki> Sotrudniki { get; set; }
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
            Sotrudniki = await _context.Sotrudniki.Where(m => m.PositionID == Dolzhnosti.ID).ToListAsync();
            return Page();
        }
    }
}