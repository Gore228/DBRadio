using System;
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
    public class IndexModel : PageModel
    {
        private readonly DBRadio.Data.DBRadioContext _context;

        public IndexModel(DBRadio.Data.DBRadioContext context)
        {
            _context = context;
        }

        public IList<GrafikRaboti> GrafikRaboti { get;set; }
        public IList<Sotrudniki> Sotrudniki { get; set; }
        public IList<Dolzhnosti> Dolzhnosti { get; set; }
        public IList<Zapisi> Zapisi { get; set; }

            public async Task OnGetAsync()
        {
            GrafikRaboti = await _context.GrafikRaboti.ToListAsync();
            Sotrudniki = await _context.Sotrudniki.ToListAsync();
            Dolzhnosti = await _context.Dolzhnosti.ToListAsync();
            Zapisi = await _context.Zapisi.ToListAsync(); 
        }
    }
}
