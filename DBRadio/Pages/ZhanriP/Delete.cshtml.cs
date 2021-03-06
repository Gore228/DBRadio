﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BDRadio.Models;
using DBRadio.Data;

namespace DBRadio.Pages.ZhanriP
{
    public class DeleteModel : PageModel
    {
        private readonly DBRadio.Data.DBRadioContext _context;

        public DeleteModel(DBRadio.Data.DBRadioContext context)
        {
            _context = context;
        }

        [BindProperty]
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
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Zhanri = await _context.Zhanri.FindAsync(id);

            if (Zhanri != null)
            {
                _context.Zhanri.Remove(Zhanri);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
