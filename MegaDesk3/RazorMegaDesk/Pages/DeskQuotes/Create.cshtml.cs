using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RazorMegaDesk.Data;
using RazorMegaDesk.Models;

namespace RazorMegaDesk.Pages.DeskQuotes
{
    public class CreateModel : PageModel
    {
        private readonly RazorMegaDesk.Data.DeskQuotesContext _context;

        public CreateModel(RazorMegaDesk.Data.DeskQuotesContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public DeskQuote DeskQuote { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.DeskQuote.Add(DeskQuote);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");

        }
            public enum SurfaceMaterial
        {
            Oak = 200,
            Laminate = 100,
            Pine = 50,
            Rosewood = 300,
            Veneer = 125,
        }
        private const decimal BASE_PRICE = 200;
        private const decimal DRAWER_UNIT_PRICE = 50;
        private const double SQUARE_INCH_THRESHOLD = 1000;
        private const decimal SQUARE_INCH_FEE = 1;

        public decimal SurfaceAreaFee(double SurfaceArea)
        {
            if (SurfaceArea > SQUARE_INCH_THRESHOLD)
            {
                decimal chargeableSurfaceArea = (decimal)(SurfaceArea - SQUARE_INCH_THRESHOLD);
                return chargeableSurfaceArea * SQUARE_INCH_FEE;
            }
            else
            {
                return 0;
            }
        }

        public decimal DrawerFee(int drawers)
        {
            return drawers * DRAWER_UNIT_PRICE;
        }

        public decimal RushFee(int days, double surfacearea)
        {
            switch (days)
            {
                case 3:
                    if (surfacearea < 1000)
                    {
                        return 60;
                    }
                    if (surfacearea >= 1000 && surfacearea <= 2000)
                    {
                        return 70;

                    }
                    if (surfacearea > 2000)
                    {
                        return 80;
                    }
                    break;
                case 5:
                    if (surfacearea < 1000)
                    {
                        return 40;
                    }
                    if (surfacearea >= 1000 && surfacearea <= 2000)
                    {
                        return 50;

                    }
                    if (surfacearea > 2000)
                    {
                        return 60;
                    }
                    break;
                case 7:
                    if (surfacearea < 1000)
                    {
                        return 30;
                    }
                    if (surfacearea >= 1000 && surfacearea <= 2000)
                    {
                        return 35;

                    }
                    if (surfacearea > 2000)
                    {
                        return 40;
                    }
                    break;
                default:
                    return 0;
            }
            return 0;
        }


        private decimal CalculateQuoteTotal(double depth, double width, int numDrawers, string surfaceMat, string rushDays)
        {
            var surfaceArea = depth * width;
            decimal materialCost = 0;
            switch (surfaceMat)
            {
                case "Oak":
                    materialCost = 200;
                    break;
                case "Laminate":
                    materialCost = 100;
                    break;

                case "Pine":
                    materialCost = 50;
                    break;

                case "Rosewood":
                    materialCost = 300;
                    break;
                case "Veneer":
                    materialCost = 125;
                    break;
            }
            decimal QuoteTotal = BASE_PRICE + SurfaceAreaFee(surfaceArea) + DrawerFee(numDrawers) + materialCost + RushFee(Int16.Parse(rushDays), surfaceArea);
            return QuoteTotal;
        }

    }
}
