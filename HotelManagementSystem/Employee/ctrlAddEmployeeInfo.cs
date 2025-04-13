using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using BusnessLayer;
using HotelManagementSystem.Classes;

namespace HotelManagementSystem.Employee
{
    public partial class ctrlAddEmployeeInfo :System.Windows.Forms. UserControl
    {
        
        public event EventHandler <OnEmployeeInfoUpdatedEventArgs> OnEmployeeInfoUpdated;
        enum EnMode { Update , Addnew}
        public ctrlAddEmployeeInfo()
        {
            InitializeComponent();
        }
        EnMode _mode = EnMode.Addnew;
        clsEmployee _Oldemployee;

        public void SetUpdateValues(clsEmployee employee)
        {
            _mode = EnMode.Update;
            HireDate.MinDate = DateTime.Now;
            _Oldemployee = employee;
            DataTable data = clsEmployeeRole.RetreiveAllRolesAndCountEmployee();
            foreach(DataRow row in data.Rows)
            {
                cmRoles.Items.Add(row[1].ToString().Trim());
            }
            txtSalary.Text = employee.salary.ToString();
            HireDate.Enabled = false; 
            cmRoles.SelectedIndex = employee.role.roleID-1;
            lbEmployeeID.Text = employee.Id.ToString();
            
        }
        public void SetAddNewValues()
        {
            _mode = EnMode.Addnew;
            HireDate.MinDate = DateTime.Now;
            DataTable data = clsEmployeeRole.RetreiveAllRolesAndCountEmployee();
            foreach (DataRow row in data.Rows)
            {
                cmRoles.Items.Add(row[1].ToString().Trim());
            }
        }
        
        public void OnEmployeeAddedSuccefully(object obj , int EmpID)
        {
            lbEmployeeID.Text = EmpID.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtSalary.Text) && cmRoles.Text.Length > 0)
            {
                if (double.TryParse(txtSalary.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out double salary))
                {
                    OnEmployeeInfoUpdated?.Invoke(this, new OnEmployeeInfoUpdatedEventArgs(salary, HireDate.Value, clsEmployeeRole.Find(cmRoles.SelectedIndex + 1)));
                }
                else
                {
                    MessageBox.Show("Invalid salary format. Please enter a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
            {
                return;
            }
            // Allow digits (0-9)
            if (char.IsDigit(e.KeyChar))
            {
                return;
            }
            // Allow a single decimal point, but not at the beginning
            if (e.KeyChar == '.' && !txtSalary.Text.Contains(".") && txtSalary.Text.Length > 0)
            {
                return;
            }
            // Block all other characters
            e.Handled = true;
        }
    }
}
