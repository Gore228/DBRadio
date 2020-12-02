using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DBRadio.Pages.Zf
{
	public class IndexModel : PageModel
	{
		private readonly DBRadio.Data.DBRadioContext _context;

		public IndexModel(DBRadio.Data.DBRadioContext context)
		{
			_context = context;
		}
		public List<SelectListItem> Dolzhnosti { get; set; }
		public List<SelectListItem> Zapisi { get; set; }
		public List<SelectListItem> Zhanri { get; set; }
		public List<SelectListItem> Date { get; set; }
		public List<SelectListItem> Sotrudniki { get; set; }

		public IActionResult OnGet()
		{
			Dolzhnosti = _context.Dolzhnosti.Select(p =>
			new SelectListItem
			{
				Value = p.ID.ToString(),
				Text = p.JobTitle
			}).ToList();
			Zapisi = _context.Ispolniteli.Select(p =>
			new SelectListItem
			{
				Value = p.ID.ToString(),
				Text = p.Name
			}).ToList();
			Zhanri = _context.Zhanri.Select(p =>
			new SelectListItem
			{
				Value = p.ID.ToString(),
				Text = p.Name
			}).ToList();
			Date = _context.GrafikRaboti.Select(p =>
			new SelectListItem					
			{
				Value = p.ID.ToString(),
				Text = p.Date.ToString()
			}).ToList();
			Sotrudniki = _context.Sotrudniki.Select(p =>
			new SelectListItem
			{
				Value = p.ID.ToString(),
				Text = p.FullName
			}).ToList();

			return Page();
		}

	}
}
