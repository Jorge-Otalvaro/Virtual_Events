using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using VirtualEvent.Model.Data;
using VirtualEvent.Model.Models;

namespace VirtualEvent.UI.Pages.Attendance
{
    public class CreateModel : PageModel
    {
        private readonly VirtualEvent.Model.Data.VirtualEventsDbContext _context;

        public CreateModel(VirtualEvent.Model.Data.VirtualEventsDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["EventId"] = new SelectList(_context.Events, "EventId", "OrganizerId");
            return Page();
        }

        [BindProperty]
        public Attendances Attendances { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attendances.Add(Attendances);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
