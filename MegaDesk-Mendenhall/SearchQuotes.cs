using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
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

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string MaterialSelected = searchCombo.SelectedItem.ToString();

            try
            {
                if (File.Exists(@"quotes.json"))
                {
                    using (StreamReader sr = new StreamReader(@"quotes.json"))
                    {
                        string jsonData = sr.ReadToEnd().Trim();

                        string[] lines = jsonData.Split(
                            new[] { "\r\n", "\r", "\n", "\\n" },
                            StringSplitOptions.None
                        );
                        List<DeskQuoteRootObj> arrayList = new List<DeskQuoteRootObj>();
                        //string[] row;

                        for (int i = 0; i < lines.Length; i++)
                        {
                            DeskQuoteRootObj DeskQuote = JsonConvert.DeserializeObject<DeskQuoteRootObj>(lines[i]);
                            //row = new string[] { DeskQuote.Name, "Element 2", "Element 3", "Element 4", "Element 5" };
                            arrayList.Add(DeskQuote);
                        }

                        var source = new BindingSource();
                        source.DataSource = arrayList;
                        searchGrid.DataSource = source;



                    }
                }

            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
