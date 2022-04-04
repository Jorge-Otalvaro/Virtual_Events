using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using VirtualEvent.Model.Data;
using VirtualEvent.Model.Models;

namespace VirtualEvent.UI.Pages.Attendance
{
    public class IndexModel : PageModel
    {
        private readonly VirtualEvent.Model.Data.VirtualEventsDbContext _context;

        public IndexModel(VirtualEvent.Model.Data.VirtualEventsDbContext context)
        {
            _context = context;
        }

        public IList<Attendances> Attendances { get;set; }

        public async Task OnGetAsync()
        {
            Attendances = await _context.Attendances
                .Include(a => a.Event).ToListAsync();
        }
    }
}
