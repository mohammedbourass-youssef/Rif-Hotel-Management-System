using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusnessLayer;
using Guna.UI2.WinForms;
using HACH_ME_EXEMPLE;
using HotelManagementSystem.Classes;
using HotelManagementSystem.Employee;

namespace HotelManagementSystem.Users
{
    public partial class frmAddOrUpdateUser : Form
    {
        public frmAddOrUpdateUser()
        {
            InitializeComponent();
        }
        ctrlFindEmployee employee;
        ctrlAddUser user;
        clsEmployee selected_employee;
        void _MoveTheJumperToMe(Guna2Button button)
        {
            pnlJumper.BackColor = Color.White;
            pnlJumper.Size = new Size(button.Width, 3);
            pnlJumper.Top = button.Bottom - 3;
            pnlJumper.Left = button.Left;
        }
        void OnEmployeeSelected(object sender , clsEmployee employee)
        {
            selected_employee = employee;
        }
        void OnSaveClicked(object sender, OnSaveClickedAddedUSerEventArgs e)
        {
            if (employee == null)
                MessageBox.Show("Please Choose An Employee Or Add Another One");
            else
            {
                clsUser user = new clsUser();
                user.username = e.username;
                user.password = clscryptography.ComputeHash(e.password);
                user.Employee = selected_employee;
                user.EmployeeID = selected_employee.Id;
                user.CreatedByuser = clsGlobal.current_user;
                user.permissions = e.permissions;
                user.IsActive = true;
                if (user.Save())
                {
                    MessageBox.Show("User Saved Succefully");
                    ctrlAddUser frm = (ctrlAddUser)sender;
                    frm.lblUserID.Text   = user.userID.ToString();
                }
                else
                {
                    MessageBox.Show("Something Wrong , please again");
                }
            }
        }
        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPersonInfo_Click(object sender, EventArgs e)
        {
            _MoveTheJumperToMe((Guna2Button)sender);
            pnlBody.Controls.Clear();
            employee.Visible = true;
            employee.Location = new Point(5, 2);
            pnlBody.Controls.Add(employee);
        }

        private void btnUserInfo_Click(object sender, EventArgs e)
        {
            _MoveTheJumperToMe((Guna2Button)sender);
            pnlBody.Controls.Clear();
            user.Visible = true;
            user.Location = new Point(5, 2);
            pnlBody.Controls.Add(user);
        }

        private void frmAddOrUpdateUser_Load(object sender, EventArgs e)
        {
             employee = new ctrlFindEmployee();
             employee.CtrlLoad();
             employee.OnEmployeeSelected += OnEmployeeSelected;

            user = new ctrlAddUser();
            user.OnSaveClicked += OnSaveClicked;

            btnPersonInfo_Click(btnEmploInfo , e);

        }

        private void pnlHeader_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
