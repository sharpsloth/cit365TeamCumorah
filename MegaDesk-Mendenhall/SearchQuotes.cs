using MegaDesk_Mendenhall;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

public struct Row {
    public string Date { get; set; }
    public string CustomerName { get; set; }
    public int Width { get; set; }
    public int Depth { get; set; }
    public DesktopMaterial Material { get; set; }
    public int RushDays { get; set; }
    public int Price { get; set; }

    public Row(string date, string customerName, int width, int depth, DesktopMaterial material, int rushDays, int price)
    {
        Date = date;
        CustomerName = customerName;
        Width = width;
        Depth = depth;
        Material = material;
        RushDays = rushDays;
        Price = price;
    }
}

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
                        List<Row> arrayList = new List<Row>();

                        for (int i = 0; i < lines.Length; i++)
                        {
                            // Read lines and parse Objects
                            DeskQuoteRootObj DeskQuote = JsonConvert.DeserializeObject<DeskQuoteRootObj>(lines[i]);
                            Row row = new Row(DeskQuote.Today, DeskQuote.Name, DeskQuote.Desk.Width, DeskQuote.Desk.Depth, 
                                DeskQuote.Desk.material, DeskQuote.RushDays, DeskQuote.Quote);
                            arrayList.Add(row);
                        }
                        // Obtener el material Seleccionado
                        DesktopMaterial selMaterial = (DesktopMaterial)Enum.Parse(typeof(DesktopMaterial), searchCombo.Text);
                        // Attach data to grid
                        var source = new BindingSource();
                        source.DataSource = arrayList.FindAll(line => line.Material == selMaterial);
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
