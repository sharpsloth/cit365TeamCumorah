using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Mendenhall
{
    public partial class AddQuote : Form
    {
        public AddQuote()
        {
            InitializeComponent();
            foreach (string item in Enum.GetNames(typeof(DesktopMaterial)))
            {
                materialSelection.Items.Add(item);
            }
        }

        private void AddQuoteCancelBttn_Click(object sender, EventArgs e)
        {
            MainMenu viewMainMenu = (MainMenu)Tag;
            viewMainMenu.Show();
            Close();

        }

        private void submitQuote_Click(object sender, EventArgs e)
        {
            string ship = shippingBox.Text;
            switch (ship)
            {
                case "3 Days":
                    shippingBox.Tag = 3;
                    break;
                case "5 Days":
                    shippingBox.Tag = 5;
                    break;
                case "7 Days":
                    shippingBox.Tag = 7;
                    break;
                default:
                    shippingBox.Tag = 14;
                    break;
            }

            int shipDays = (int)shippingBox.Tag;
            DisplayQuote viewQuote = new DisplayQuote(nameBox.Text, depthBox.Text, 
                widthBox.Text, drawerSelection.Text, materialSelection.Text, shipDays);
            viewQuote.Tag = this.Tag;
            viewQuote.Show(this);
            this.Hide();
        }

        private void depthBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && !Char.IsControl(ch))
            {
                e.Handled = true;
            }
        }

        private void depthBox_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidDepthNumbers(depthBox.Text, out errorMsg))
            {
                // Cancel the event and select the text to be corrected by the user.
                e.Cancel = true;
                depthBox.Select(0, depthBox.Text.Length);

                // Set the ErrorProvidor error with the text to display.
                this.errorProviderDepth.SetError(depthBox, errorMsg);
            }
        }

        private void depthBox_Validated(object sender, System.EventArgs e)
        {
            // if all conditions have been met, clear the ErrorProvider or errors.
            errorProviderDepth.SetError(depthBox, "");
        }
        public bool ValidDepthNumbers(string text, out string errorMessage)
        {
                int num = int.Parse(text);
            if (num < 49 && num > 11)
            {
                errorMessage = "";
                return true;
            }
            else
            {
                errorMessage = "Must be between 12 and 24 inches.";
                return false;
            }
        }

        private void widthBox_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidWidthNumbers(widthBox.Text, out errorMsg))
            {
                // Cancel the event and select the text to be corrected by the user.
                e.Cancel = true;
                widthBox.Select(0, widthBox.Text.Length);

                // Set the ErrorProvidor error with the text to display.
                this.errorProviderWidth.SetError(widthBox, errorMsg);
            }
        }

        private void widthBox_Validated(object sender, System.EventArgs e)
        {
            // if all conditions have been met, clear the ErrorProvider or errors.
            errorProviderWidth.SetError(widthBox, "");
        }
        public bool ValidWidthNumbers(string text, out string errorMessage)
        {
            int num;
            try
            {
                num = int.Parse(text);
            }
            catch (Exception e)
            {
                errorMessage = "Must be a number.";
                return false;
            }
            if (num < 97 && num > 23)
            {
                errorMessage = "";
                return true;
            }
            else
            {
                errorMessage = "Must be between 24 and 96 inches.";
                return false;
            }
        }
    }
}
