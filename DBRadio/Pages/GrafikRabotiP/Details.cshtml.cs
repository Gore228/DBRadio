﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BDRadio.Models;
using DBRadio.Data;

namespace DBRadio.Pages.GrafikRabotiP
{
    public class DetailsModel : PageModel
    {
        private readonly DBRadio.Data.DBRadioContext _context;

        public DetailsModel(DBRadio.Data.DBRadioContext context)
        {
            _context = context;
        }

        public GrafikRaboti GrafikRaboti { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            GrafikRaboti = await _context.GrafikRaboti.FirstOrDefaultAsync(m => m.ID == id);

            if (GrafikRaboti == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
