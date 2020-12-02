using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DBRadio.Data;
using BDRadio.Models;

namespace DBRadio.Pages.Zf.Zaprosi
{
    public class SetkaVeshyaniya : PageModel
    {
        private readonly DBRadio.Data.DBRadioContext _context;

        public SetkaVeshyaniya(DBRadio.Data.DBRadioContext context)
        {
            _context = context;
        }

        public IList<GrafikRaboti> GrafikRaboti { get; set; }
        public IList<Sotrudniki> Sotrudniki { get; set; }
        public IList<Zapisi> Zapisi { get; set; }

        public async Task OnGetAsync()
        {
            GrafikRaboti = await _context.GrafikRaboti.ToListAsync();
            Sotrudniki = await _context.Sotrudniki.ToListAsync();
            Zapisi = await _context.Zapisi.ToListAsync();
        }
    }
}