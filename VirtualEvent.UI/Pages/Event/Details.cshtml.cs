using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using VirtualEvent.Model.Data;
using VirtualEvent.Model.Models;

namespace VirtualEvent.UI.Pages.Event
{
    public class DetailsModel : PageModel
    {
        private readonly VirtualEvent.Model.Data.VirtualEventsDbContext _context;

        public DetailsModel(VirtualEvent.Model.Data.VirtualEventsDbContext context)
        {
            _context = context;
        }

        public Events Events { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Events = await _context.Events.FirstOrDefaultAsync(m => m.EventId == id);

            if (Events == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
