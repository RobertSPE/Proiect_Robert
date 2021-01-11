using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Proiect_Robert.Data;
using Proiect_Robert.Models;

namespace Proiect_Robert.Pages.Games
{
    public class IndexModel : PageModel
    {
        private readonly Proiect_Robert.Data.Proiect_RobertContext _context;

        public IndexModel(Proiect_Robert.Data.Proiect_RobertContext context)
        {
            _context = context;
        }

        public IList<Game> Game { get;set; }

        public async Task OnGetAsync()
        {
            Game = await _context.Game.ToListAsync();
        }
    }
}
