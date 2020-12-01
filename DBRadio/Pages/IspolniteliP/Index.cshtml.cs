using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BDRadio.Models;
using DBRadio.Data;

namespace DBRadio.Pages.IspolniteliP
{
    public class IndexModel : PageModel
    {
        private readonly DBRadio.Data.DBRadioContext _context;

        public IndexModel(DBRadio.Data.DBRadioContext context)
        {
            _context = context;
        }

        public IList<Ispolniteli> Ispolniteli { get;set; }

        public async Task OnGetAsync()
        {
            Ispolniteli = await _context.Ispolniteli.ToListAsync();
        }
    }
}
