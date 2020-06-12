using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorMegaDesk.Data;
using RazorMegaDesk.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorMegaDesk.Data;
using RazorMegaDesk.Models;

namespace RazorMegaDesk.Pages.DeskQuotes
{
    public class IndexModel : PageModel
    {
        private readonly RazorMegaDesk.Data.DeskQuotesContext _context;

        public IndexModel(RazorMegaDesk.Data.DeskQuotesContext context)
        {
            _context = context;
        }

        public string NameSort { get; set; }
        public string DateSort { get; set; }
        public string CurrentFilter { get; set; }
        public string CurrentSort { get; set; }
        public IList<DeskQuote> DeskQuote { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        // creates a selectlist to filter by Customer Name
        public async Task OnGetAsync(string sortOrder)
        {
            NameSort = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            DateSort = sortOrder == "Date" ? "date_desc" : "Date";

            var quotes = from m in _context.DeskQuote
                         select m;

            switch (sortOrder)
            {
                case "name_desc":
                    quotes = quotes.OrderByDescending(e => e.CustomerName);
                    break;
                case "Date":
                    quotes = quotes.OrderBy(e => e.QuoteDate);
                    break;
                case "date_desc":
                    quotes = quotes.OrderByDescending(e => e.QuoteDate);
                    break;
                default:
                    quotes = quotes.OrderBy(e => e.CustomerName);
                    break;
            }

            if (!string.IsNullOrEmpty(SearchString))
            {
                quotes = quotes.Where(s => s.CustomerName.Contains(SearchString));
            }

            DeskQuote = await quotes.ToListAsync();
        }
    }
}
