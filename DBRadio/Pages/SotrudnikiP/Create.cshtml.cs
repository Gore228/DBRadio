using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using BDRadio.Models;
using DBRadio.Data;

namespace DBRadio.Pages.SotrudnikiP
{
    public class CreateModel : PageModel
    {
        private readonly DBRadio.Data.DBRadioContext _context;

        public CreateModel(DBRadio.Data.DBRadioContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Sotrudniki Sotrudniki { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Sotrudniki.Add(Sotrudniki);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
