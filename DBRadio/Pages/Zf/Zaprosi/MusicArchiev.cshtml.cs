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
    public class MusicArchiev : PageModel
    {
        private readonly DBRadio.Data.DBRadioContext _context;

        public MusicArchiev(DBRadio.Data.DBRadioContext context)
        {
            _context = context;
        }

        public IList<Zapisi> Zapisi { get; set; }
        public IList<Ispolniteli> Ispolniteli { get; set; }
        public IList<Zhanri> Zhanri { get; set; }

        public async Task OnGetAsync()
        {
            Zapisi = await _context.Zapisi.ToListAsync();
            Ispolniteli = await _context.Ispolniteli.ToListAsync();
            Zhanri = await _context.Zhanri.ToListAsync();
        }
    }
}