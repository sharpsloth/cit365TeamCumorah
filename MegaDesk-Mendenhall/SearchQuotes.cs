using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace MegaDesk_Mendenhall
{
    public partial class SearchQuotes : Form
    {
        public SearchQuotes()
        {
            InitializeComponent();
            // Jose Concha
            List<DesktopMaterial> deskMaterialsList = Enum.GetValues(typeof(DesktopMaterial)).Cast<DesktopMaterial>().ToList();
            searchCombo.DataSource = deskMaterialsList;
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            // Jose Concha
            MainMenu viewMainMenu = (MainMenu)Tag;
            viewMainMenu.Show();
        }
        private void returnMainMenu_Click(object sender, EventArgs e)
        {
            MainMenu viewMainMenu = (MainMenu)Tag;
            viewMainMenu.Show();
            Close();
        }
    }
}
