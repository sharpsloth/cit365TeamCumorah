using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorMegaDesk.Models
{
    public enum DesktopMaterial
    {
        Oak,
        Laminate,
        Pine,
        Rosewood,
        Veneer
    }
    public class DeskQuote
    {
        public int ID { get; set; }
        [Display(Name = "Shipping Speed")]
        public int RushDays { get; set; }
        [Display(Name = "Customer Name")]
        public string CustomerName { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Date of Quote")]
        public DateTime QuoteDate { get; set; }
        [Display(Name = "Desk Width")]
        public int DeskWidth { get; set; }
        [Display(Name = "Desk Depth")]
        public int DeskDepth { get; set; }
        [EnumDataType(typeof(DesktopMaterial))]
        [Display(Name = "Desktop Material")]
        public DesktopMaterial DeskMaterial { get; set; }
        [Display(Name = "Number of Dawers")]
        public int DeskDrawers { get; set; }

        [Display(Name = "Price")]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        [Required]
        public decimal Price { get; set; }

        public Desk Desk { get; set; }

        private const decimal BASE_DESK_PRICE = 200.00M;
        private const decimal SURFACE_AREA_RATE = 1;
        private const decimal DRAWER_RATE = 50.00M;

        private decimal GetDeskPrice(decimal surfaceArea)
        {
            decimal deskPrice = BASE_DESK_PRICE +
                                surfaceArea * SURFACE_AREA_RATE +
                                Desk.NumberOfDrawers * DRAWER_RATE +
                                Desk.SurfaceMaterial.Price;

            return deskPrice;
        }

    }
}
