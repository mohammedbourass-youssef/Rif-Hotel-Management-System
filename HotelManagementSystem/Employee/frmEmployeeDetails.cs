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

namespace HotelManagementSystem.Employee
{
    public partial class frmEmployeeDetails : Form
    {
        clsEmployee _currentEmployee = null;
        public frmEmployeeDetails(clsEmployee employee)
        {
            InitializeComponent();
            _currentEmployee = employee;
        }

        private void frmEmployeeDetails_Load(object sender, EventArgs e)
        {
            ctrlEmployeeCard1.LoadTheData(_currentEmployee);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
