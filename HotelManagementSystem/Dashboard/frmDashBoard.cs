using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using BusnessLayer;
using Guna.UI2.WinForms;
using HotelManagementSystem.Classes;
using HotelManagementSystem.People;
using HotelManagementSystem.Properties;
using HotelManagementSystem.Reservations;
using HotelManagementSystem.Users;

namespace HotelManagementSystem.Dashboard
{
    public partial class frmDashBoard : Form
    {
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            SetRoundedRegion(30); // Call function to make the form rounded
        }
        enum EnShowUserInfoStatus {Up,Down }
        public frmDashBoard()
        {
            InitializeComponent();
        }
        //varibles 
        EnShowUserInfoStatus _ShowUserInfoStatus = EnShowUserInfoStatus.Down;
        //Logic Functions 
        void _ChangeTimeAndDate()
        {
            lblTimeAndDate.Text = DateTime.Now.ToString("F");
        }
        //Design functions
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
        void _ChangeShowUserDetailsStatus()
        {
            if (_ShowUserInfoStatus == EnShowUserInfoStatus.Up)
            {
                _ShowUserInfoStatus = EnShowUserInfoStatus.Down;
                btnShowUserDetails.Image = Resources.icons8_down_40;
            }
            else
            {
                _ShowUserInfoStatus = EnShowUserInfoStatus.Up;
                btnShowUserDetails.Image = Resources.icons8_up_40;
            }
        }

        //events
        private void btnShowUserDetails_Click(object sender, EventArgs e)
        {
            _ChangeShowUserDetailsStatus();
            frmUserDetails frmUser = new frmUserDetails(clsGlobal.current_user);
            frmUser.ShowDialog();
            _ChangeShowUserDetailsStatus();
        }
        void _SetPicture()
        {
            clsGlobal.current_user.Employee = clsEmployee.Find(clsGlobal.current_user.EmployeeID);
            if (string.IsNullOrEmpty(clsGlobal.current_user.Employee.person.picturepath))
            {
                if (clsGlobal.current_user.Employee.person.gender == EnGender.Female)
                {
                    pbProfile.Image = Resources.WomanBlank;
                }
                else
                {
                    pbProfile.Image = Resources.UserManBlank;

                }
            }
            else
            {
                pbProfile.Image = Image.FromFile(clsGlobal.current_user.Employee.person.picturepath.Trim());
            }
        }
       
        private void LoadChartData()
        {
            // Get data (replace this with your own CRUD function)
            DataTable dt = clsGuests.GetDataOfTheReservationOfMonth(DateTime.Now.Month);

            // Clear old data
            incomeChart.Series.Clear();
            incomeChart.ChartAreas.Clear();
            incomeChart.Legends.Clear();
            incomeChart.Titles.Clear();

            // Add Chart Area
            incomeChart.ChartAreas.Add("ChartArea1");
            incomeChart.ChartAreas[0].BackColor = Color.Transparent;

            // Add a title above the chart
            Title title = new Title("Daily Reservation Count for " + DateTime.Now.ToString("MMMM yyyy"),
                                    Docking.Top, new Font("Arial", 14, FontStyle.Bold), Color.Black);
            incomeChart.Titles.Add(title);

            // Create a Legend (Optional)
            Legend legend = new Legend("Legend1")
            {
                BackColor = Color.Transparent,
                Docking = Docking.Bottom,
                Alignment = StringAlignment.Center
            };
            incomeChart.Legends.Add(legend);

            // Create Spline Area Series
            Series series = new Series("Reservations")
            {
                ChartType = SeriesChartType.SplineArea, // Spline Area Chart
                Color = Color.FromArgb(235, 138, 20), // Semi-transparent pink
                BorderColor = Color.FromArgb(235, 40, 60), // Line color
                BorderWidth = 3
            };

            // Add Data Points
            foreach (DataRow row in dt.Rows)
            {
                string date = Convert.ToDateTime(row["Day"]).ToShortDateString();
                double reservations = Convert.ToDouble(row["number Of reservation"]);
                series.Points.AddXY(date, reservations);
            }

            // Add series to chart
            incomeChart.Series.Add(series);

            // Improve visuals
            incomeChart.ChartAreas[0].AxisX.LabelStyle.Angle = -45; // Rotate labels for better visibility
            incomeChart.ChartAreas[0].AxisX.Interval = 1; // Show all days
            incomeChart.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.LightGray;
            incomeChart.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.LightGray;

            // Enable markers for data points
            series.MarkerStyle = MarkerStyle.Circle;
            series.MarkerSize = 6;
            series.MarkerColor = Color.Blue;
        }

        private void frmDashBoard_Load(object sender, EventArgs e)
        {
            _ChangeTimeAndDate();
            lblWelcome.Text =  lblWelcome.Text.Replace("user4", clsGlobal.current_user.username);
            clsGlobal.current_user.Employee = clsEmployee.Find(clsGlobal.current_user.EmployeeID);
            lblFullName.Text = clsGlobal.current_user.Employee.person.GetFullName();
            lblEmail.Text = clsGlobal.current_user.Employee.person.email;
            _SetPicture();
            _SetAllAllSectionsDEfaultValue();
            LoadChartData();
            lblMonth.Text = DateTime.Now.ToString("MMMM") + "-" + DateTime.Now.Year.ToString();
            
        }
        void _SetAllAllSectionsDEfaultValue()
        {
            lblNumberOfRooms.Text = clsRooms.CountAvailableRooms().ToString();
            lblTodayCheckOut.Text = clsReservation.TodaysCheckOut().ToString();
            if (int.Parse(lblTodayCheckOut.Text) < 10)
            {
                lblTodayCheckOut.Text = "0" + lblTodayCheckOut.Text;
            }
            lblCheckin.Text = clsReservation.TodaysCheckIn().ToString();
            if( int.Parse(lblCheckin.Text)<10)
                lblCheckin.Text = "0"+lblCheckin.Text;
            lblNumberOfUsers.Text = clsUser.CountNumberOfUser().ToString();
            if (int.Parse(lblNumberOfUsers.Text) < 10)
                lblNumberOfUsers.Text = "0" + lblNumberOfUsers.Text;
            lblNumberGuest.Text = clsUser.CountCountGuestsWeHave().ToString();
            if (int.Parse(lblNumberGuest.Text) < 10)
                lblNumberGuest.Text = "0" + lblNumberGuest.Text;
            lblIncome.Text = clsGuests.GettotalGuestOfThisMonth(DateTime.Now.Month).ToString();
        }
        private void Timer_OF_GeneraleTime_Tick(object sender, EventArgs e)
        {
            _ChangeTimeAndDate();
        }
        Size _normalSize = new Size(258, 10);
        Size _ExtendlSize = new Size(258, 179);
        enum EnPnlMenuStatus { Extend, normal}
        EnPnlMenuStatus _pnlStatus = EnPnlMenuStatus.normal;



        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            pnlJumper.Visible = false;
            if (_pnlStatus == EnPnlMenuStatus.normal)
            {
                clsOtils.EtendPanel(pnlMenu, _ExtendlSize);
                _pnlStatus = EnPnlMenuStatus.Extend;
            }
            else
            {
                clsOtils.Reset(pnlMenu, _normalSize);
                _pnlStatus = EnPnlMenuStatus.normal;
            }
        }
        void _MoveTheJumperToMe(Guna2Button button)
        {
            pnlJumper.Visible = true;
            pnlJumper.BackColor = Color.White;
            pnlJumper.Size = new Size(button.Width, 2);
            pnlJumper.Top = button.Bottom - 3;
            pnlJumper.Left = button.Left;
        }
        private void btnManageUsers_Click(object sender, EventArgs e)
        {
            clsOtils.Reset(pnlMenu, _normalSize);
            _MoveTheJumperToMe((Guna2Button)sender);
            _pnlStatus = EnPnlMenuStatus.normal;
            frmAddOrUpdatePerson frm = new frmAddOrUpdatePerson(clsGlobal.current_user.Employee.person, true);
            frm.ShowDialog();
           
        }

        private void btnManagePersons_Click(object sender, EventArgs e)
        {
          
            clsOtils.Reset(pnlMenu, _normalSize);
            _MoveTheJumperToMe((Guna2Button)sender);
            _pnlStatus = EnPnlMenuStatus.normal;
            frmChangeUserName frm = new frmChangeUserName(clsGlobal.current_user, frmChangeUserName.EnMode.ByUser);
            frm.ShowDialog();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            clsOtils.Reset(pnlMenu, _normalSize);
            _MoveTheJumperToMe((Guna2Button)sender);
            _pnlStatus = EnPnlMenuStatus.normal;
            frmChangePassword frm = new frmChangePassword(clsGlobal.current_user , frmChangePassword.EnMode.ByUser);
            frm.ShowDialog();
        }

        private void btnAddNewReservation_Click(object sender, EventArgs e)
        {
            frmAddNewReservations frm = new frmAddNewReservations();
            frm.ShowDialog();
        }

        private void pictureBox5_MouseEnter(object sender, EventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;
            pictureBox.BackColor = Color.FromArgb(235, 40, 60);
        }

        private void guna2GradientPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;
            pictureBox.BackColor = Color.Transparent;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }
    }
}
