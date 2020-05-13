using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Mendenhall
{
    class DeskQuoteRootObj
    {
        public string Name { get; set; }
        public Desk Desk { get; set; }
        public int RushDays { get; set; }
        public int MaterialCost { get; set; }
        public int DrawerCost { get; set; }
        public int SizeCost { get; set; }
        public int Quote { get; set; }
        public string Today { get; set; }
        public string DeliveryDate { get; set; }

    }
}
