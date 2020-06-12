using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

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

        private int DRAWER_PRICE = 50;
        private int BASE_PRICE = 200;
        private int PRICE_PER_INCH = 1;
        private int INCLUDED_INCHES = 1000;
        private int MIN_WIDTH { get; set; } = 24;
        private int MAX_WIDTH { get; set; } = 96;
        private int MIN_DEPTH { get; set; } = 12;
        private int MAX_DEPTH { get; set; } = 48;

        public int GetArea()
        {
            int area = this.DeskDepth * this.DeskWidth;
            return area;
        }

    }
}
