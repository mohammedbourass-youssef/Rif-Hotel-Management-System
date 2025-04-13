using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using BusnessLayer;

namespace HotelManagementSystem.Payement
{
    public partial class frmManagePayements : Form
    {
        public frmManagePayements()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            SetRoundedRegion(30); // Call function to make the form rounded
        }
        private void SetRoundedRegion(int radius)
        {
            GraphicsPath path = new GraphicsPath();
            int d = radius * 2;
            Rectangle rect = this.ClientRectangle;

            // Create arcs for rounded corners
            path.AddArc(rect.X, rect.Y, d, d, 180, 90);
            path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90);
            path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90);
            path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90);

            path.CloseFigure();
            this.Region = new Region(path); // Apply rounded region
        }
        private void frmManagePayements_Load(object sender, EventArgs e)
        {
            lblName.Text = clsGuests.GetLoyaleGuests();
            LoadChartData();
            LoadChartDataOfYear();
            ChartOfMethods();
            ChartAnalyticsOfRoomsCategory();
            lblTotalYearOfYear.Text = lblTotalYearOfYear.Text + " " + DateTime.Now.Year.ToString();
            lblTotalPrice.Text = clsPayement.CountTotalIncomeOfYear(DateTime.Now.Year).ToString() + " $";
            lblMostUsedPayemeMethod.Text = clsPayement.GetTheMostUsedMethodOfPayement();
            lblTopReserved.Text = clsPayement.GetTheMostUsedRoomCategories();
            lblMostCountry.Text = clsPayement.GetTheMostCountry();
            lblIncomeDay.Text = DateTime.Now.ToString("D") + " "+lblIncomeDay.Text;
            lblTotalIncome.Text = lblTotalIncome.Text+" "+ clsPayement.CountTotalIncomeOf(DateTime.Now.Month).ToString() +" $ ";
            lblTotalIcomeOfThisDay.Text = clsPayement.CountOdTotalIncomOfDaySpecial(DateTime.Now).ToString() + " $ ";
            LoadChartDataOfCancels();
            lblCanceled.Text = clsPayement.CountCanceldReservation(DateTime.Now.Month).ToString();
        }
        private void LoadChartDataOfYear()
        {
            // Get data
            DataTable dt = clsPayement.GetAnalyticsOfThisAllYear(DateTime.Now.Year);

            // Clear old data
            TotalIncomeOfYear.Series.Clear();
            TotalIncomeOfYear.ChartAreas.Clear();
            TotalIncomeOfYear.Legends.Clear();
            TotalIncomeOfYear.Titles.Clear();
            TotalIncomeOfYear.ChartAreas.Add("ChartArea1");

            // Set chart background to transparent
            TotalIncomeOfYear.BackColor = Color.Transparent;
            TotalIncomeOfYear.ChartAreas[0].BackColor = Color.Transparent;
            TotalIncomeOfYear.ChartAreas[0].AxisX.MajorGrid.Enabled = false; // Remove X-axis grid lines
            TotalIncomeOfYear.ChartAreas[0].AxisY.MajorGrid.Enabled = false; // Remove Y-axis grid lines

            // Add a title above the chart
  

            // Create legend and move it below the chart
         

            // Create a spline area series
            Series series = new Series("Income")
            {
                ChartType = SeriesChartType.SplineArea,
                Color = Color.FromArgb(235, 40, 60), // Adjust color to match the image
                BorderWidth = 0, // Removes the lines
                BorderColor = Color.Transparent // Ensures no visible borders
            };

            // Add data points with proper legend labels
            foreach (DataRow row in dt.Rows)
            {
                string month = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(Convert.ToInt32(row["month"]));
                double income = Convert.ToDouble(row["amount"]);
                DataPoint point = new DataPoint();
                point.SetValueXY(month, income);
                point.Label = income.ToString("C"); // Show values as currency
                point.LegendText = month;
                series.Points.Add(point);
            }

            // Add series to chart
            TotalIncomeOfYear.Series.Add(series);

            // Remove labels inside the pie slices
            series.IsValueShownAsLabel = true;

            // Apply a gradient color to match the image
            series.Color = Color.FromArgb(255, 99, 132);

            // Optionally apply a 3D effect
            //TotalIncomeOfYear.ChartAreas[0].Area3DStyle.Enable3D = true;
        }
        private void LoadChartData()
        {
            // Get data
            DataTable dt = clsPayement.GetAnalyticsOfThisAllMonths(DateTime.Now.Month);

            // Clear old data
            incomeChart.Series.Clear();
            incomeChart.ChartAreas.Clear();
            incomeChart.Legends.Clear();
            incomeChart.Titles.Clear();
            incomeChart.ChartAreas.Add("ChartArea1");

            // Set chart background to transparent
            incomeChart.BackColor = Color.Transparent;
            incomeChart.ChartAreas[0].BackColor = Color.Transparent;
            incomeChart.ChartAreas[0].AxisX.MajorGrid.Enabled = false; // Remove X-axis grid lines
            incomeChart.ChartAreas[0].AxisY.MajorGrid.Enabled = false; // Remove Y-axis grid lines

            // Add a title above the chart
            Title title = new Title("Daily Income Distribution of month \n" + DateTime.Now.ToString("MMMM") + "-" + DateTime.Now.Year.ToString(), Docking.Top, new Font("Arial", 14, FontStyle.Bold), Color.Black);
            incomeChart.Titles.Add(title);

            // Create legend and move it below the chart
            Legend legend = new Legend("Legend1")
            {
                BackColor = Color.Transparent,
                Docking = Docking.Bottom, // Moves the legend below the chart
                Alignment = StringAlignment.Center
            };
            incomeChart.Legends.Add(legend);

            // Create a Pie series
            Series series = new Series("Income")
            {
                ChartType = SeriesChartType.SplineArea,
                Color = Color.FromArgb(235, 138, 20),
                BorderWidth = 0, // Removes the lines
                BorderColor = Color.Transparent // Ensures no visible borders
            };

            // Add data points with proper legend labels
            foreach (DataRow row in dt.Rows)
            {
                string date = Convert.ToDateTime(row["Date"]).ToShortDateString();
                double income = Convert.ToDouble(row["Total Income"]);
                DataPoint point = new DataPoint();
                point.SetValueXY("", income); // Empty for inside pie slice
                point.Label = null; // Hide labels on slices
                point.LegendText = date; // Set legend to show the date
                series.Points.Add(point);
            }

            // Add series to chart
            incomeChart.Series.Add(series);

            // Remove labels inside the pie slices
            series.IsValueShownAsLabel = false;

            // Apply a 3D style (optional)
            //incomeChart.ChartAreas[0].Area3DStyle.Enable3D = true;
        }
        private void ChartOfMethods()
        {
            // Get data
            DataTable dt = clsPayement.GetTheAnalyticsOfPayementMethod();

            // Clear old data
            BestMethodOfPayement.Series.Clear();
            BestMethodOfPayement.ChartAreas.Clear();
            BestMethodOfPayement.Legends.Clear();
            BestMethodOfPayement.Titles.Clear();
            BestMethodOfPayement.ChartAreas.Add("ChartArea1");

            // Set chart background to transparent
            BestMethodOfPayement.BackColor = Color.Transparent;
            BestMethodOfPayement.ChartAreas[0].BackColor = Color.Transparent;
            BestMethodOfPayement.ChartAreas[0].AxisX.MajorGrid.Enabled = false; // Remove X-axis grid lines
            BestMethodOfPayement.ChartAreas[0].AxisY.MajorGrid.Enabled = false; // Remove Y-axis grid lines

            // Add a title above the chart
            // Create legend and move it below the chart

            // Create a bar series
            Series series = new Series("Payment Methods")
            {
                ChartType = SeriesChartType.Bar,
                Color = Color.FromArgb(235, 40, 60), // Adjust color to match the image
                BorderWidth = 0, // Removes the lines
                BorderColor = Color.Transparent // Ensures no visible borders
            };

            // Add data points with proper legend labels
            foreach (DataRow row in dt.Rows)
            {
                string methodName = row["MethodName"].ToString();
                int number = Convert.ToInt32(row["Number"]);
                DataPoint point = new DataPoint();
                point.SetValueXY(methodName, number);
                point.Label = number.ToString(); // Show values
                point.LegendText = methodName;
                series.Points.Add(point);
            }

            // Add series to chart
            BestMethodOfPayement.Series.Add(series);

            // Remove labels inside the pie slices
            series.IsValueShownAsLabel = true;

            // Apply a gradient color to match the image
            series.Color = Color.FromArgb(255, 99, 132);

            // Optionally apply a 3D effect
            //BestMethodOfPayement.ChartAreas[0].Area3DStyle.Enable3D = true;
        }
        private void ChartAnalyticsOfRoomsCategory()
        {
            // Get data
            DataTable dt = clsPayement.GetTheAnalyticsOfRoomsCategory();

            // Clear old data
            AnalyticsOfRoomsCategory.Series.Clear();
            AnalyticsOfRoomsCategory.ChartAreas.Clear();
            AnalyticsOfRoomsCategory.Legends.Clear();
            AnalyticsOfRoomsCategory.Titles.Clear();
            AnalyticsOfRoomsCategory.ChartAreas.Add("ChartArea1");

            // Set chart background to transparent
            AnalyticsOfRoomsCategory.BackColor = Color.Transparent;
            AnalyticsOfRoomsCategory.ChartAreas[0].BackColor = Color.Transparent;
            AnalyticsOfRoomsCategory.ChartAreas[0].AxisX.MajorGrid.Enabled = false; // Remove X-axis grid lines
            AnalyticsOfRoomsCategory.ChartAreas[0].AxisY.MajorGrid.Enabled = false; // Remove Y-axis grid lines

            // Add a title above the chart


            // Create legend and move it below the chart

            // Create a bar series
            Series series = new Series("Room Categories")
            {
                ChartType = SeriesChartType.StackedBar,
                Color = Color.FromArgb(255, 99, 132), // Adjust color to match the image
                BorderWidth = 0, // Removes the lines
                BorderColor = Color.Transparent // Ensures no visible borders
            };

            // Add data points with proper legend labels
            foreach (DataRow row in dt.Rows)
            {
                string methodName = row["Category"].ToString();
                int number = Convert.ToInt32(row["Number"]);
                DataPoint point = new DataPoint();
                point.SetValueXY(methodName, number);
                point.Label = number.ToString(); // Show values
                point.LegendText = methodName;
                series.Points.Add(point);
            }

            // Add series to chart
            AnalyticsOfRoomsCategory.Series.Add(series);

            // Remove labels inside the pie slices
            series.IsValueShownAsLabel = true;

            // Apply a gradient color to match the image
            series.Color = Color.FromArgb(255, 99, 132);

            // Optionally apply a 3D effect
            //AnalyticsOfRoomsCategory.ChartAreas[0].Area3DStyle.Enable3D = true;
        }
        private void LoadChartDataOfCancels()
        {
            // Get data 
            DataTable dt = clsPayement.GetTheAnalyticsOfCancelDay(DateTime.Now);

            // Clear old data 
            CancelsChart.Series.Clear();
            CancelsChart.ChartAreas.Clear();
            CancelsChart.Legends.Clear();
            CancelsChart.Titles.Clear();
            CancelsChart.ChartAreas.Add("ChartArea1");

            // Set chart background to transparent 
            CancelsChart.BackColor = Color.Transparent;
            CancelsChart.ChartAreas[0].BackColor = Color.Transparent;
            CancelsChart.ChartAreas[0].AxisX.MajorGrid.Enabled = false; // Remove X-axis grid lines 
            CancelsChart.ChartAreas[0].AxisY.MajorGrid.Enabled = false; // Remove Y-axis grid lines 

            // Create a spline area series 
            Series series = new Series("Cancellations")
            {
                ChartType = SeriesChartType.SplineArea,
                Color = Color.FromArgb(235, 40, 60), // Adjust color 
                BorderWidth = 0, // Removes the lines 
                BorderColor = Color.Transparent // Ensures no visible borders 
            };

            // Add data points with proper legend labels 
            foreach (DataRow row in dt.Rows)
            {
                string day = row["DAY"].ToString();
                double total = Convert.ToDouble(row["Total"]);
                DataPoint point = new DataPoint();
                point.SetValueXY(day, total);
                point.Label = total.ToString(); // Show values 
                point.LegendText = "Day " + day;
                series.Points.Add(point);
            }

            // Add series to chart 
            CancelsChart.Series.Add(series);

            // Show values on the chart 
            series.IsValueShownAsLabel = true;

            // Apply a gradient color 
            series.Color = Color.FromArgb(255, 99, 132);
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAllPayements frm = new frmAllPayements();
            frm.ShowDialog();
        }
    }
}
