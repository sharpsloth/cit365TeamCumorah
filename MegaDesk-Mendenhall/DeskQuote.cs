using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Mendenhall
{
    class DeskQuote
    {
        private string name;
        private Desk desk;
        private int rushDays;
        private int materialCost;
        private int drawerCost;
        private int rushCost;
        private int sizeCost;
        private int quote;
        private DateTime date = DateTime.Today;
        private string today;
        private string deliveryDate;
        protected int DRAWER_PRICE = 50;
        protected int BASE_PRICE = 200;
        protected int PRICE_PER_INCH = 1;
        protected int INCLUDED_INCHES = 1000;

        public string Name { get { return name; } set { name = value; } }
        public Desk Desk { get { return desk; } set { desk = value; } }
        public int RushDays { get { return rushDays; } set { rushDays = value; } }
        public int MaterialCost { get { return materialCost; } set { materialCost = value; } }
        public int DrawerCost { get { return drawerCost; } set { drawerCost = value; } }
        public int RushCost { get { return rushCost; } set { rushCost = value; } }
        public int SizeCost { get { return sizeCost; } set { sizeCost = value; } }
        public int Quote { get { return quote; } set { quote = value; } }
        public string Today { get { return today; } set { today = value; } }
        public string DeliveryDate { get { return deliveryDate; } set { deliveryDate = value; } }

        public DeskQuote(string name, int depth, int width, int drawers, 
            string material, int shipping)
        {
            this.name = name;
            this.desk = new Desk(depth, width, drawers, material);
            this.rushDays = shipping;
            this.rushCost = CalcRushCost();
            this.materialCost = CalcMaterialCost();
            this.drawerCost = CalcDrawerCost();
            this.sizeCost = CalcSizeCost();
            this.quote = CalcQuote();
            this.today = date.ToString("d");
            DateTime delivery = date.AddDays(shipping);
            this.deliveryDate = delivery.ToString("d");
        }

        public int GetBasePrice() {return BASE_PRICE;}
        public int GetPricePerIn() { return PRICE_PER_INCH; }
        public int GetDrawerPrice() { return DRAWER_PRICE; }
        public int GetRushCost() { return rushCost; }
        public int CalcMaterialCost()
        {
            string material = desk.material.ToString();
            int cost = 0;
            switch (material)
            {
                case "Pine":
                    cost= 50;
                    break;
                case "Oak":
                    cost = 200;
                    break;
                case "Laminate":
                    cost = 100;
                    break;
                case "Rosewood":
                    cost = 300;
                    break;
                case "Veneer":
                    cost = 125;
                    break;
            }
            return cost;
        }

        public int CalcRushCost()
        {
            int cost = 0;
            int shipDays = this.rushDays;
            int area = this.desk.Area;
            switch (shipDays)
            {
                case 3:
                    if (area < 1000){cost = 60; break;} 
                    else if (area <= 2000){cost = 70; break;} 
                    else {cost = 80; break;}
                case 5:
                    if (area < 1000) { cost = 40; break; }
                    else if (area <= 2000) { cost = 50; break; }
                    else { cost = 60; break; }
                case 7:
                    if (area < 1000) { cost = 30; break; }
                    else if (area <= 2000) { cost = 35; break; }
                    else { cost = 40; break; }
                case 14:
                    break;
            }
            return cost;
        }

        public int CalcDrawerCost()
        {
            int price = DRAWER_PRICE;
            int drawers = this.desk.Drawers;
            int cost = price * drawers;
            return cost;
        }

        public int CalcSizeCost()
        {
            int cost = 0;
            int overage = this.desk.Area - INCLUDED_INCHES;
            if (overage > 0)
            {
                cost = overage * PRICE_PER_INCH;
            }
            return cost;
        }

        public int CalcQuote()
        {
            int cost = BASE_PRICE + sizeCost + rushCost + materialCost + drawerCost;
            return cost;
        }

        public int Overage()
        {
            int overage = desk.Area - INCLUDED_INCHES;
            if (overage > 0)
            {
                return overage;
            }
            else
            {
                return 0;
            }
        }

    }
}
