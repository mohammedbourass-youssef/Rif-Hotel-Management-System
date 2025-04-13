using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;
using BusnessLayer;

namespace HotelManagementSystem.Employee
{
    public partial class frmManageEmployee : Form
    {
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
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            SetRoundedRegion(30); // Call function to make the form rounded
        }
        void _LoadAllEmployees()
        {
            dgvAllEmployees.DataSource = clsEmployee.GetSpecial();
        }

        enum EnFilter {
            None,EmployeeID,Full_Name,Role,Country,Hire_Date,Salary,Fired
        }
        public frmManageEmployee()
        {
            InitializeComponent();
        }
        //varible 
        EnFilter filter = EnFilter.None;


        //logical function 

        void _LoadAllCountries()
        {
            DataTable dt = clsEmployee.GetSpecial();
            cmCountries.Items.Add("None");
            foreach (DataRow dr in dt.Rows)
            {
                if (!IsExist(dr[3].ToString().Trim()))
                    cmCountries.Items.Add(dr[3].ToString().Trim());
            }
            cmCountries.SelectedIndex = 0;
        }
        void _LoadAllRoles()
        {
            DataTable dt = clsEmployeeRole.RetreiveAllRolesAndCountEmployee();
            cmRoles.Items.Add("None");
            foreach (DataRow dr in dt.Rows)
            {
                cmRoles.Items.Add(dr[1].ToString().Trim());
            }
            cmRoles.SelectedIndex = 0;
        }
        bool IsExist(string i)
        {
            foreach (string item in cmCountries.Items)
            {
                if (i == item) return true;
            }
            return false;
        }
        void _makeTheFiredFilterByDefault()
        {
            cmFilter.SelectedIndex = cmFilter.Items.Count-1;
            cmFilter_SelectedIndexChanged(cmFilter, new EventArgs());
            cmFired.SelectedIndex = 1;
            cmFired_SelectedIndexChanged(cmFired, new EventArgs());

        }
        private void frmManageEmployee_Load(object sender, EventArgs e)
        {
            _LoadAllEmployees();
            _LoadAllCountries();
            _LoadAllRoles();

            cmSalaryComparaisom.SelectedIndex = 0;
            _makeTheFiredFilterByDefault();
        }

        private void cmFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            _LoadAllEmployees();
            //Set all Invisble : 
            cmCountries.Visible = false;
            cmFired.Visible = false;
            txtSearch.Visible = false;
            cmRoles.Visible = false;
            HireDate.Visible = false;
            cmSalaryComparaisom.Visible = false;
            //Logic
            txtSearch.Text = string.Empty;
            switch(cmFilter.SelectedIndex)
            {
                case 0:
                    filter = EnFilter.None;
                    break;
                case 1:
                    filter = EnFilter.EmployeeID;
                    txtSearch.Visible = true;
                    break;
                case 2:
                    filter = EnFilter.Full_Name;
                    txtSearch.Visible = true;
                    break;
                case 3:
                    filter = EnFilter.Role;
                    cmRoles.Visible = true;
                    break;
                case 4:
                    filter = EnFilter.Country;
                    cmCountries.Visible=true;
                    break;
                case 5:
                    filter = EnFilter.Hire_Date;
                    HireDate.Visible = true;
                    break;
                case 6:
                    filter = EnFilter.Salary;
                    cmSalaryComparaisom.Visible=true;
                    txtSearch.Visible=true;
                    break;
                case 7:
                    filter = EnFilter.Fired;
                    
                    cmFired.Visible=true;
                    break;
            }
        }
        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (filter == EnFilter.EmployeeID)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true; // Block the input
                }
            }
            else if(filter == EnFilter.Salary)
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
                if (e.KeyChar == '.' && !txtSearch.Text.Contains(".") && txtSearch.Text.Length > 0)
                {
                    return;
                }
                // Block all other characters
                e.Handled = true;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataTable table = clsEmployee.GetSpecial();
            if (!string.IsNullOrEmpty(txtSearch.Text))
            {
                if (filter != EnFilter.EmployeeID && filter != EnFilter.Salary)
                {
                    DataView view = table.DefaultView;
                    view.RowFilter = "[" + cmFilter.Text + "] LIKE '" + txtSearch.Text + "%'";
                    dgvAllEmployees.DataSource = view;
                }

                else if(filter == EnFilter.EmployeeID )
                {
                    DataView view = table.DefaultView;
                    view.RowFilter = cmFilter.Text + " = '" + txtSearch.Text + "'";
                    dgvAllEmployees.DataSource = view;
                }
                else if(filter == EnFilter.Salary )
                {
                   
                    if (filter == EnFilter.Salary)
                    {
                        DataView view = table.DefaultView;

                        // Ensure that cmFilter.Text is a valid column name
                        string columnName = cmFilter.Text;
                        string symbol = _DetectSimbole().ToString();
                        string searchValue = txtSearch.Text;

                        // Assuming Salary is a numeric field, do not use single quotes
                        view.RowFilter = $"[{columnName}] {symbol} {searchValue}";

                        dgvAllEmployees.DataSource = view;
                    }
                }
            }
            else
            {
                 _LoadAllEmployees();
            }
        }

        private void cmRoles_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable table = clsEmployee.GetSpecial();
           if(cmRoles.SelectedIndex != 0)
            {
                if (filter == EnFilter.Role)
                {
                    DataView view = table.DefaultView;
                    view.RowFilter = "[" + cmFilter.Text + "] = '" + cmRoles.Text + "'";
                    dgvAllEmployees.DataSource = view;
                }
            }
           else 
                { _LoadAllEmployees(); }
        }

        private void cmFired_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmFired.SelectedIndex != 0)
            {
                DataTable table = clsEmployee.GetSpecial();
                if (filter == EnFilter.Fired)
                {
                    DataView view = table.DefaultView;
                    view.RowFilter = "[" + cmFilter.Text + "] LIKE '" + cmFired.Text.Substring(0,3).Trim() + "%'";
                    dgvAllEmployees.DataSource = view;
                }
            }
            else 
                { _LoadAllEmployees(); }
        }

        private void cmCountries_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable table = clsEmployee.GetSpecial();
            if (filter == EnFilter.Country)
            {
                DataView view = table.DefaultView;
                view.RowFilter = cmFilter.Text + " = '" + cmCountries.Text + "'";
                dgvAllEmployees.DataSource = view;
            }
        }

        private void HireDate_ValueChanged(object sender, EventArgs e)
        {
            DataTable table = clsEmployee.GetSpecial();
            if (HireDate.Value != DateTime.Now)
            {
                if (filter == EnFilter.Hire_Date)
                {
                    DataView view = table.DefaultView;
                    view.RowFilter = "[" + cmFilter.Text + "] = '" + HireDate.Value.ToString("yyyy-MM-dd") + "'";
                    dgvAllEmployees.DataSource = view;
                }
            }
            else
            { _LoadAllEmployees(); }
        }
        char _DetectSimbole()
        {
            switch (cmSalaryComparaisom.SelectedIndex)
            {
                case 0: return '<';
                case 1: return '>';
                case 2: return '=';
                default: return '=';
            }
        }

        private void cmSalaryComparaisom_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text.Length > 0)
            {
                DataTable table = clsEmployee.GetSpecial();
                if (filter == EnFilter.Salary)
                {
                    DataView view = table.DefaultView;

                    // Ensure that cmFilter.Text is a valid column name
                    string columnName = cmFilter.Text;
                    string symbol = _DetectSimbole().ToString();
                    string searchValue = txtSearch.Text;

                    // Assuming Salary is a numeric field, do not use single quotes
                    view.RowFilter = $"[{columnName}] {symbol} {searchValue}";

                    dgvAllEmployees.DataSource = view;
                }
            }
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            frmEmployeeDetails frm = new frmEmployeeDetails(clsEmployee.Find((int)dgvAllEmployees.CurrentRow.Cells[0].Value));
            frm.ShowDialog();
        }

        private void dgvAllEmployees_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmEmployeeDetails frm = new frmEmployeeDetails(clsEmployee.Find((int)dgvAllEmployees.CurrentRow.Cells[0].Value));
            frm.ShowDialog();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            frmAddOrUpdateEmployee frm = new frmAddOrUpdateEmployee();
            frm.ShowDialog();
            _LoadAllEmployees();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmAddOrUpdateEmployee frm = new frmAddOrUpdateEmployee(clsEmployee.Find((int)dgvAllEmployees.CurrentRow.Cells[0].Value));
            frm.ShowDialog();
            _LoadAllEmployees();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you Want To Terminate this Employment ? Fire him ? Thats Elimate him As user ?", "Attention",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (clsEmployee.FireEmployee((int)dgvAllEmployees.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("Employee Fired Succefully");
                    _LoadAllEmployees() ;
                }
                else
                {
                    MessageBox.Show("An error detected , try again ");
                }
            }
        }

        private void g_Opening(object sender, CancelEventArgs e)
        {
            if((string)dgvAllEmployees.CurrentRow.Cells[6].Value != "NO")
            {
                FiredItems.Enabled = false;
                PayTheSalary.Enabled = false;
                SetUSer.Enabled = false;
                EditEmployee.Enabled = false;
            }
            else
            {
                FiredItems.Enabled = true;
                PayTheSalary.Enabled = true;
                SetUSer.Enabled = true;
                EditEmployee.Enabled = true;
            }

            
        }

        private void PayTheSalary_Click(object sender, EventArgs e)
        {
            if (clsEmployessSalaryPayment.IsTheEmployeePayedmonth((int)dgvAllEmployees.CurrentRow.Cells[0].Value, DateTime.Now))
            {
                MessageBox.Show("Sorry Error detected ...  Maybe this Employee Already Get his Salary, Or You don't Have Permission", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                
            }
        }
    }
}
