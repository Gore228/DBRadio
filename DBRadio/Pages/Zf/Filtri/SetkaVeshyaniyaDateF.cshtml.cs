using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DBRadio.Data;
using BDRadio.Models;
using System.Collections;

namespace DBRadio.Pages.Zf.Filtri
{
    public class SetkaVeshyaniyaDateF : PageModel
    {
        private readonly DBRadio.Data.DBRadioContext _context;

        public SetkaVeshyaniyaDateF(DBRadio.Data.DBRadioContext context)
        {
            _context = context;
        }

        public IList<GrafikRaboti> GrafikRaboti { get; set; }
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
            GrafikRaboti = await _context.GrafikRaboti.Where(m => m.StaffID == Zapisi.ID).ToListAsync();
            return Page();

        }
    }
    
}