﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BDRadio.Models;
using DBRadio.Data;

namespace DBRadio.Pages.IspolniteliP
{
    public class EditModel : PageModel
    {
        private readonly DBRadio.Data.DBRadioContext _context;

        public EditModel(DBRadio.Data.DBRadioContext context)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Ispolniteli).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!IspolniteliExists(Ispolniteli.ID))
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

        private bool IspolniteliExists(long id)
        {
            return _context.Ispolniteli.Any(e => e.ID == id);
        }
    }
}
