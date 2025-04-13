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

namespace HotelManagementSystem.Users
{
    public partial class frmUserDetails : Form
    {
        clsUser user = null;
        public frmUserDetails(clsUser user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void frmUserDetails_Load(object sender, EventArgs e)
        {
            clsEmployee employee = clsEmployee.Find(user.EmployeeID);
            if (employee != null)
            {
                ctrlEmployeeCard1.LoadTheData(employee);
                lblUserID.Text = user.userID.ToString();
                lblUserName.Text = user.username;
            }             
            else
            {
                MessageBox.Show("Error To Dowload This Form , Please check the USer And Try Again");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
