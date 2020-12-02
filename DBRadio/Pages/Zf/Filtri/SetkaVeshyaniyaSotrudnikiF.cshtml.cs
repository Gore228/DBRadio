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
    public class SetkaVeshyaniyaSotrudnikiF : PageModel
    {
        private readonly DBRadio.Data.DBRadioContext _context;

        public SetkaVeshyaniyaSotrudnikiF(DBRadio.Data.DBRadioContext context)
        {
            _context = context;
        }

        public IList<GrafikRaboti> GrafikRaboti { get; set; }
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
            GrafikRaboti = await _context.GrafikRaboti.Where(m => m.StaffID == Sotrudniki.ID).ToListAsync();
            return Page();

        }
    }

}