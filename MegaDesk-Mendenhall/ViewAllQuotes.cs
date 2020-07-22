using MegaDesk_Mendenhall;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.ComponentModel;

public struct AllRow
{
    public string Date { get; set; }
    public string CustomerName { get; set; }
    public int Width { get; set; }
    public int Depth { get; set; }
    public DesktopMaterial Material { get; set; }
    public int RushDays { get; set; }
    public int Price { get; set; }

    public AllRow(string date, string customerName, int width, int depth, DesktopMaterial material, int rushDays, int price)
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

        private void ViewAllQuotes_Load(object sender, EventArgs e)
        {
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

                        //Fill a new data table for sorting
                        DataTable dt = new DataTable();
                        dt.Columns.Add("Date");
                        dt.Columns.Add("CustomerName");
                        dt.Columns.Add("Width");
                        dt.Columns.Add("Depth");
                        dt.Columns.Add("Material");
                        dt.Columns.Add("RushDays");
                        dt.Columns.Add("Price");
                        foreach (var item in arrayList)
                        {
                            dt.Rows.Add(item.Date, item.CustomerName, item.Width, item.Depth, item.Material, item.RushDays, item.Price);
                        }
                        dataGridViewAll.DataSource = dt;

                        //dataGridViewAll.DataSource = arrayList;
                    }
                }

            }
            catch (Exception)
            {
                throw;
            }
        }

        private void sortDateBtn_Click(object sender, EventArgs e)
        {
            dataGridViewAll.Sort(dataGridViewAll.Columns[0], ListSortDirection.Ascending);
        }

        private void sortCustomerNameBtn_Click(object sender, EventArgs e)
        {
            dataGridViewAll.Sort(dataGridViewAll.Columns[1], ListSortDirection.Ascending);
        }

        private void sortMaterialBtn_Click(object sender, EventArgs e)
        {
            dataGridViewAll.Sort(dataGridViewAll.Columns[4], ListSortDirection.Ascending);
        }

        private void sortRushDaysBtn_Click(object sender, EventArgs e)
        {
            dataGridViewAll.Sort(dataGridViewAll.Columns[5], ListSortDirection.Ascending);
        }
    }


}
