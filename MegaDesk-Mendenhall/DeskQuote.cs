using Newtonsoft.Json;
using System;
using System.IO;

namespace MegaDesk_Mendenhall
{
    class DeskQuote
    {
/*        private string name;
        private Desk desk;
        private int rushDays;
        private int materialCost;
        private int drawerCost;
        private int rushCost;
        private int sizeCost;
        private int quote; */
        private DateTime date = DateTime.Today;
//        private string today;
//        private string deliveryDate;
        protected int DRAWER_PRICE = 50;
        protected int BASE_PRICE = 200;
        protected int PRICE_PER_INCH = 1;
        protected int INCLUDED_INCHES = 1000;

        public string Name { get; set; }
        public Desk Desk { get; set; }
        public int RushDays { get; set; }
        public int MaterialCost { get; set; }
        public int DrawerCost { get; set; }
        public int RushCost { get; set; }
        public int SizeCost { get; set; }
        public int Quote { get; set; }
        public string Today { get; set; }
        public string DeliveryDate { get; set; }

        public DeskQuote(string name, int depth, int width, int drawers,
            string material, int shipping)
        {
            this.Name = name;
            this.Desk = new Desk(depth, width, drawers, material);
            this.RushDays = shipping;
            this.RushCost = CalcRushCost();
            this.MaterialCost = CalcMaterialCost();
            this.DrawerCost = CalcDrawerCost();
            this.SizeCost = CalcSizeCost();
            this.Quote = CalcQuote();
            this.Today = date.ToString("d");
            DateTime delivery = date.AddDays(shipping);
            this.DeliveryDate = delivery.ToString("d");
        }

        public int GetBasePrice() { return BASE_PRICE; }
        public int GetPricePerIn() { return PRICE_PER_INCH; }
        public int GetDrawerPrice() { return DRAWER_PRICE; }
        public int GetRushCost() { return RushCost; }
        public int CalcMaterialCost()
        {
            string material = Desk.material.ToString();
            int cost = 0;
            switch (material)
            {
                case "Pine":
                    cost = 50;
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


        // Clarisse Mendenhall (new for group project)
        // create a 2d array from file to calculate rush cost
        public const string RUSHPRICES = @"rushOrderPrices.txt";

        public static int[,] GetRushPrices()
        {
            string[] lines = File.ReadAllLines(RUSHPRICES);

            int[,] rushPrice = new int[3, 3];

            try
            {
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        rushPrice[i, j] = Int32.Parse(lines[(i * 3) + j]);
                    }
                }
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("Exception caught: {0}", e);
            }
            return rushPrice;
        }

        // Clarisse Mendenhall - update this method to use 2d array
        public int CalcRushCost()
        {
            int cost = 0;
            int shipDays = this.RushDays;
            int area = this.Desk.Area;
            switch (shipDays)
            {
                case 3:
                    if (area < 1000) { cost = GetRushPrices()[0, 0]; break; }
                    else if (area <= 2000) { cost = GetRushPrices()[0, 1]; break; }
                    else { cost = GetRushPrices()[0, 2]; break; }
                case 5:
                    if (area < 1000) { cost = GetRushPrices()[1, 0]; break; }
                    else if (area <= 2000) { cost = GetRushPrices()[1, 1]; break; }
                    else { cost = GetRushPrices()[1, 2]; break; }
                case 7:
                    if (area < 1000) { cost = GetRushPrices()[2, 0]; break; }
                    else if (area <= 2000) { cost = GetRushPrices()[2, 1]; break; }
                    else { cost = GetRushPrices()[2, 2]; break; }
                case 14:
                    break;
            }
            return cost;
        }

        public int CalcDrawerCost()
        {
            int price = DRAWER_PRICE;
            int drawers = this.Desk.Drawers;
            int cost = price * drawers;
            return cost;
        }

        public int CalcSizeCost()
        {
            int cost = 0;
            int overage = this.Desk.Area - INCLUDED_INCHES;
            if (overage > 0)
            {
                cost = overage * PRICE_PER_INCH;
            }
            return cost;
        }

        public int CalcQuote()
        {
            int cost = BASE_PRICE + SizeCost + RushCost + MaterialCost + DrawerCost;
            return cost;
        }

        public int Overage()
        {
            int overage = Desk.Area - INCLUDED_INCHES;
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
