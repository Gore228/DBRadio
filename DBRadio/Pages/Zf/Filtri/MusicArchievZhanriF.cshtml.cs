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
    public class MusicArchievZhanriF : PageModel
    {
        private readonly DBRadio.Data.DBRadioContext _context;

        public MusicArchievZhanriF(DBRadio.Data.DBRadioContext context)
        {
            _context = context;
        }

        public IList<Zapisi> Zapisi { get; set; }
        public Zhanri Zhanri { get; set; }
        public async Task<IActionResult> OnGetAsync(long? id)
        {

            if (id == null)
            {
                return NotFound();
            }

            Zhanri = await _context.Zhanri.FirstOrDefaultAsync(m => m.ID == id);

            if (Zhanri == null)
            {
                return NotFound();
            }
            Zapisi = await _context.Zapisi.Where(m => m.GenreID == Zhanri.ID).ToListAsync();
            return Page();
        }
    }
}