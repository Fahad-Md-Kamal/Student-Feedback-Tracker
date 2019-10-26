using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ADIDemoDec19
{
    public partial class frmBarChart : Form
    {
        Database1Entities db = new Database1Entities();

        public static List<string> seriesArray;
        public static List<int> pointsArray;
        public frmBarChart()
        {
            InitializeComponent();
        }

        private void frmBarChart_Load(object sender, EventArgs e)
        {
            // Set palette.
            this.chart1.Palette = ChartColorPalette.Pastel;
            // Set title.
            this.chart1.Titles.Add("BAR Chart");

            //chart1.Series[0].LegendText = "Name";
            //chart1.Series[0].ChartType = SeriesChartType.Bar;
            //chart1.Series[0].IsValueShownAsLabel = true;
            //chart1.Series[0].Points.DataBindXY(seriesArray, pointsArray);

            DrawChart();
        }

        void DrawChart()
        {
            try
            {
                //============== TextBox ====================
                List<string> lstData = new List<string>();
                List<int> lstValue = new List<int>();

                seriesArray = lstData;
                pointsArray = lstValue;

                
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid Data !!!");
            }

            var data = db.Assessments.Select(d => new { d.User.uName, d.mark }).ToList();

            //Fetch the Statistical data from database.
            //string query = "SELECT uid., COUNT(OrderId) [Total]";
            //query += " FROM Orders WHERE ShipCountry = 'Brazil'";
            //query += " GROUP BY ShipCity";
            //DataTable dt = GetData(query);

            //Get the names of Cities.

            /*
            string[] x = (from p in dt.AsEnumerable()
                          orderby p.Field<string>("ShipCity") ascending
                          select p.Field<string>("ShipCity")).ToArray();

            //Get the Total of Orders for each City.
            int[] y = (from p in dt.AsEnumerable()
                       orderby p.Field<string>("ShipCity") ascending
                       select p.Field<int>("Total")).ToArray();

            */
            chart1.Series[0].LegendText = "Bar Chart Statistics";
            chart1.Series[0].ChartType = SeriesChartType.Bar;
            chart1.Series[0].IsValueShownAsLabel = true;
            //chart1.Series[0].Points.DataBindXY(x, y);
            chart1.DataSource = data;
            chart1.Series["Series1"].XValueMember = "uName";
            chart1.Series["Series1"].YValueMembers = "mark";



        }

        private static DataTable GetData(string query)
        {
            string constr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Munaz\Desktop\ADI 6c\ADIDemoDec19\ADIDemoDec19\Database1.mdf;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlDataAdapter sda = new SqlDataAdapter(query, con))
                {
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    return dt;
                }
            }
        }
    }
}
