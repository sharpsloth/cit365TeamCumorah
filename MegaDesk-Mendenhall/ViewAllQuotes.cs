using System;
using System.Windows.Forms;

namespace MegaDesk_Mendenhall
{
    public partial class ViewAllQuotes : Form
    {
        public ViewAllQuotes()
        {
            InitializeComponent();
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
