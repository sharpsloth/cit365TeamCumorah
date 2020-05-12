using System;
using System.Windows.Forms;

namespace MegaDesk_Mendenhall
{
    public partial class DisplayQuote : Form
    {
        public DisplayQuote(string name, string depth, string width,
            string drawers, string material, int shipping)
        {
            InitializeComponent();
            int depth1 = int.Parse(depth);
            int width1 = int.Parse(width);
            int drawers1 = int.Parse(drawers);
            DeskQuote desk = new DeskQuote(name, depth1, width1, drawers1, material, shipping);
            displayName.Text = desk.Name;
            todaysDate.Text = desk.Today;
            basePrice.Text = $"${desk.GetBasePrice()}.00";
            displayCostPerIn.Text = $"${desk.GetPricePerIn()}.00";
            displayArea.Text = $"{desk.Desk.Area} in²";
            displayOverage.Text = $"{desk.Overage()} in²";
            displaySizeCost.Text = $"${desk.SizeCost}.00";
            drawerPrice.Text = $"${desk.GetDrawerPrice()}.00";
            drawerAmount.Text = $"{desk.Desk.Drawers}";
            drawerCost.Text = $"${desk.DrawerCost}.00";
            materialName.Text = material;
            materialCost.Text = $"${desk.MaterialCost}.00";
            rushStatus.Text = $"{desk.RushDays} days. Delivery by: {desk.DeliveryDate}";
            rushCost.Text = $"${desk.GetRushCost()}.00";
            totalCost.Text = $"${desk.Quote}.00";

        }

        private void returnMainMenu_Click(object sender, EventArgs e)
        {
            MainMenu viewMainMenu = (MainMenu)Tag;
            viewMainMenu.Show();
            Close();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            // Jose Concha
            MainMenu viewMainMenu = (MainMenu)Tag;
            viewMainMenu.Show();
        }

    }
}
