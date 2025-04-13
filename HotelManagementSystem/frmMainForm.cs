using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusnessLayer;
using Guna.UI2.WinForms;
using HotelManagementSystem.Classes;
using HotelManagementSystem.Dashboard;
using HotelManagementSystem.Employee;
using HotelManagementSystem.Guests;
using HotelManagementSystem.orders;
using HotelManagementSystem.Payement;
using HotelManagementSystem.People;
using HotelManagementSystem.Reservations;
using HotelManagementSystem.Rooms;
using HotelManagementSystem.Users;

namespace HotelManagementSystem
{
    public partial class frmMainForm : Form
    {
        enum EnCurrentClickedButton {None,Dashboard,Reservations ,Employees , people , users , EmployeesRoles , ManageRooms , RoomCategory ,ManageGuets ,reportAndPayement, Orders }
        Form _perviousOpened = null;
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
        public frmMainForm()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            SetRoundedRegion(10); // Call function to make the form rounded
        }
        //Variable 
        EnCurrentClickedButton clickedButton = EnCurrentClickedButton.None;
        private void frmMainForm_Load(object sender, EventArgs e)
        {
            clsGlobal.mainForm = this;
            btnDashboad_Click(btnDashboad, e);
            pnlEmployeesCountiner.Size = btnDashboad.Size;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Exit ? ", "Attention", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1,
                MessageBoxOptions.RightAlign) == DialogResult.OK)
                this.Close();
        }

        private void btnDashboad_Click(object sender, EventArgs e)
        {
            if(clickedButton != EnCurrentClickedButton.Dashboard)
            {
                if (_perviousOpened != null)
                    _perviousOpened.Close();
                clickedButton = EnCurrentClickedButton.Dashboard;
                clsOtils.ResetSideBarButtonStatus();
                frmDashBoard frmDash = new frmDashBoard();
                frmDash.TopLevel = false;
                pnlBody.Controls.Add(frmDash);
                frmDash.Dock = DockStyle.Fill;
                frmDash.Show();
                _perviousOpened = frmDash;
            }
        }
        

        private void btnReservation_Click(object sender, EventArgs e)
        {
            if(clickedButton != EnCurrentClickedButton.Reservations)
            {

                if (clsGlobal.current_user.HavePermissionOf(EnPermissions.ManageReservations))
                {
                    if (_perviousOpened != null)
                        _perviousOpened.Close();
                    clickedButton = EnCurrentClickedButton.Reservations;
                    clsOtils.ResetSideBarButtonStatus();
                    frmReservations frm = new frmReservations();
                    frm.TopLevel = false;
                    pnlBody.Controls.Add(frm);
                    frm.Dock = DockStyle.Fill;
                    frm.Show();
                    _perviousOpened = frm;
                }
                else
                {
                    MessageBox.Show("Access Denied");
                }
                
            }

        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            if(clickedButton != EnCurrentClickedButton.Employees)
            {
                if (clsGlobal.current_user.HavePermissionOf(EnPermissions.ManageEmployee))
                {
                    if (_perviousOpened != null)
                        _perviousOpened.Close();
                    clickedButton = EnCurrentClickedButton.Employees;
                    clsOtils.ExpandSideBarButtonStatus(pnlEmployeesCountiner);
                    frmManageEmployee frm = new frmManageEmployee();
                    frm.TopLevel = false;
                    pnlBody.Controls.Add(frm);
                    frm.Dock = DockStyle.Fill;
                    frm.Show();
                    _perviousOpened = frm;
                }
                else
                {
                    MessageBox.Show("Access Denied");
                }
            }
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            clsOtils.ResetSideBarButtonStatus();
            if (clickedButton != EnCurrentClickedButton.users)
            {
                if (clsGlobal.current_user.HavePermissionOf(EnPermissions.ManageUsers))
                {
                    clsOtils.ResetSideBarButtonStatus();
                    if (_perviousOpened != null)
                        _perviousOpened.Close();
                    clickedButton = EnCurrentClickedButton.users;

                    frmManageUsers frm = new frmManageUsers();
                    frm.TopLevel = false;
                    pnlBody.Controls.Add(frm);
                    frm.Dock = DockStyle.Fill;
                    frm.Show();
                    _perviousOpened = frm;
                }
                else
                {
                    MessageBox.Show("Access Denied");
                }
              
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void btnShowRoles_Click(object sender, EventArgs e)
        {
            if (clickedButton != EnCurrentClickedButton.EmployeesRoles)
            {
                
                if (_perviousOpened != null)
                    _perviousOpened.Close();
                clickedButton = EnCurrentClickedButton.EmployeesRoles;
                frmEmployesRoles frm = new frmEmployesRoles();
                frm.TopLevel = false;
                pnlBody.Controls.Add(frm);
                frm.Dock = DockStyle.Fill;
                frm.Show();
                _perviousOpened = frm;
            }
        }

        private void btnManagePersons_Click(object sender, EventArgs e)
        {
            if(clickedButton != EnCurrentClickedButton.people)
            {

                if (clsGlobal.current_user.HavePermissionOf(EnPermissions.ManagePeople))
                {
                    clsOtils.ResetSideBarButtonStatus();
                    if (_perviousOpened != null)
                        _perviousOpened.Close();
                    clickedButton = EnCurrentClickedButton.people;
                    frmManagePeople frm = new frmManagePeople();
                    frm.TopLevel = false;
                    pnlBody.Controls.Add(frm);
                    frm.Dock = DockStyle.Fill;
                    frm.Show();
                    _perviousOpened = frm;
                }
                else
                {
                    MessageBox.Show("Access Denied");
                }
            
               
            }
        }

        private void guna2Button2_Click_1(object sender, EventArgs e)
        {
            if (clickedButton != EnCurrentClickedButton.ManageRooms)
            {
                if (clsGlobal.current_user.HavePermissionOf(EnPermissions.ManageRooms))
                {
                if (_perviousOpened != null)
                        _perviousOpened.Close();
                    clickedButton = EnCurrentClickedButton.ManageRooms;
                    clsOtils.ExpandSideBarButtonStatus(pnlRoomsContiner);
                frmManageRooms frm = new frmManageRooms();
                frm.TopLevel = false;
                pnlBody.Controls.Add(frm);
                frm.Dock = DockStyle.Fill;
                frm.Show();
                _perviousOpened = frm;
                }
                else
                {
                    MessageBox.Show("Access Denied");
                }
            }
        }

        private void btnRoomsCategories_Click(object sender, EventArgs e)
        {
            if (clickedButton != EnCurrentClickedButton.RoomCategory)
            {

                if (_perviousOpened != null)
                    _perviousOpened.Close();
                clickedButton = EnCurrentClickedButton.RoomCategory;
                frmManageRoomsCategory frm = new frmManageRoomsCategory();
                frm.TopLevel = false;
                pnlBody.Controls.Add(frm);
                frm.Dock = DockStyle.Fill;
                frm.Show();
                _perviousOpened = frm;
            }
        }

        private void btnManageGuests_Click(object sender, EventArgs e)
        {
            if (clickedButton != EnCurrentClickedButton.ManageGuets)
            {

                if (clsGlobal.current_user.HavePermissionOf(EnPermissions.ManageGuets))
                {
                    clsOtils.ResetSideBarButtonStatus();
                    if (_perviousOpened != null)
                        _perviousOpened.Close();
                    clickedButton = EnCurrentClickedButton.ManageGuets;
                frmManageGuests frm = new frmManageGuests();
                frm.TopLevel = false;
                pnlBody.Controls.Add(frm);
                frm.Dock = DockStyle.Fill;
                frm.Show();
                _perviousOpened = frm;
                }
                else
                {
                    MessageBox.Show("Access Denied");
                }
            }
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            if (clickedButton != EnCurrentClickedButton.reportAndPayement)
            {

                if (clsGlobal.current_user.HavePermissionOf(EnPermissions.ManagePayement))
                {
                clsOtils.ResetSideBarButtonStatus();
                if (_perviousOpened != null)
                    _perviousOpened.Close();
                clickedButton = EnCurrentClickedButton.reportAndPayement;
                frmManagePayements frm = new frmManagePayements();
                frm.TopLevel = false;
                pnlBody.Controls.Add(frm);
                frm.Dock = DockStyle.Fill;
                frm.Show();
                _perviousOpened = frm;
                }
                else
                {
                    MessageBox.Show("Access Denied");
                }
            }
        }

        private void btnRoomsServices_Click(object sender, EventArgs e)
        {
            if (clickedButton != EnCurrentClickedButton.Orders)
            {

                if (clsGlobal.current_user.HavePermissionOf(EnPermissions.ManageOrders))
                {
                    clsOtils.ResetSideBarButtonStatus();
                    if (_perviousOpened != null)
                        _perviousOpened.Close();
                    clickedButton = EnCurrentClickedButton.Orders;
                    frmAllOrders frm = new frmAllOrders();
                    frm.TopLevel = false;
                    pnlBody.Controls.Add(frm);
                    frm.Dock = DockStyle.Fill;
                    frm.Show();
                    _perviousOpened = frm;
                }
                else
                {
                    MessageBox.Show("Access Denied");
                }
            }
        }
    }
}
