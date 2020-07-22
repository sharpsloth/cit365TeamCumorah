using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Win32.SafeHandles;
using RazorMegaDesk.Data;
using RazorMegaDesk.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorMegaDesk.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new DeskQuotesContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<DeskQuotesContext>>()))
            {
                // Look for any movies.
                if (context.DeskQuote.Any())
                {
                    return;   // DB has been seeded
                }

                context.DeskQuote.AddRange(
                    new DeskQuote
                    {
                        RushDays = 5,
                        CustomerName = "Sally",
                        QuoteDate = DateTime.Parse("2009-4-16"),
                        DeskWidth = 36,
                        DeskDepth = 36,
                        DeskMaterial = (DesktopMaterial)0,
                        DeskDrawers = 4
                    },

                    new DeskQuote
                    {
                        RushDays = 3,
                        CustomerName = "James",
                        QuoteDate = DateTime.Parse("2012-6-26"),
                        DeskWidth = 24,
                        DeskDepth = 30,
                        DeskMaterial = (DesktopMaterial)1,
                        DeskDrawers = 3
                    }, new DeskQuote

                    {
                        RushDays = 5,
                        CustomerName = "Thomas",
                        QuoteDate = DateTime.Parse("2018-10-3"),
                        DeskWidth = 56,
                        DeskDepth = 24,
                        DeskMaterial = (DesktopMaterial)2,
                        DeskDrawers = 1
                    },

                    new DeskQuote
                    {
                        RushDays = 7,
                        CustomerName = "William",
                        QuoteDate = DateTime.Parse("2019-2-14"),
                        DeskWidth = 52,
                        DeskDepth = 36,
                        DeskMaterial = (DesktopMaterial)3,
                        DeskDrawers = 5
                    },

                    new DeskQuote
                    {
                        RushDays = 14,
                        CustomerName = "Eleanor",
                        QuoteDate = DateTime.Parse("2003-11-22"),
                        DeskWidth = 48,
                        DeskDepth = 24,
                        DeskMaterial = (DesktopMaterial)4,
                        DeskDrawers = 4
                    },

                    new DeskQuote
                    {
                        RushDays = 3,
                        CustomerName = "Sally",
                        QuoteDate = DateTime.Parse("2019-5-1"),
                        DeskWidth = 60,
                        DeskDepth = 24,
                        DeskMaterial = (DesktopMaterial)3,
                        DeskDrawers = 7
                    },

                    new DeskQuote
                    {
                        RushDays = 14,
                        CustomerName = "Clarisse",
                        QuoteDate = DateTime.Parse("2020-4-9"),
                        DeskWidth = 52,
                        DeskDepth = 28,
                        DeskMaterial = (DesktopMaterial)4,
                        DeskDrawers = 6
                    },

                    new DeskQuote
                    {
                        RushDays = 3,
                        CustomerName = "Tony",
                        QuoteDate = DateTime.Parse("2009-6-30"),
                        DeskWidth = 96,
                        DeskDepth = 24,
                        DeskMaterial = (DesktopMaterial)2,
                        DeskDrawers = 6
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
