using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Proiect_Robert.Pages
{
    public class BibliografieModel : PageModel
    {
        private readonly ILogger<BibliografieModel> _logger;

        public BibliografieModel(ILogger<BibliografieModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}
