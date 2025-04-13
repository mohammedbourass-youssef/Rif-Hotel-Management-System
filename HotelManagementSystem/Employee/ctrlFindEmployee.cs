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
    public partial class ctrlFindEmployee : UserControl
    {
        public event EventHandler<clsEmployee> OnEmployeeSelected;
        public ctrlFindEmployee()
        {
            InitializeComponent();
        }
        enum EnFilter
        {
             EmployeeID, Full_Name
        }
        EnFilter filter = EnFilter.EmployeeID;
        void EmployeeAdded(object sender , clsEmployee employee)
        {
            OnEmployeeSelected?.Invoke(this, employee);
            ctrlEmployeeCard1.LoadTheData(employee);
        }

        public void SetAsUser(clsEmployee employee)
        {
            ctrlEmployeeCard1.LoadTheData(employee);
            guna2Panel1.Enabled = false;
        }
        private void cmFilter_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            switch (cmFilter.SelectedIndex)
            {
                case 0:
                    filter = EnFilter.EmployeeID;
                    break;
                case 1:
                    filter = EnFilter.Full_Name;
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
        }
        public void CtrlLoad()
        {
            cmFilter.SelectedIndex = 0; 
        }

        private void btnFind_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(txtSearch.Text))
            {
                if(filter == EnFilter.EmployeeID)
                {
                    clsEmployee employee = clsEmployee.Find(int.Parse(txtSearch.Text));
                    if (employee == null)
                        MessageBox.Show("Incorrect Information , Try Again");
                    else
                    {
                        if (clsUser.IsExist(employee.Id))
                        {
                            MessageBox.Show("This Employee Already An User Of this System");
                        }else
                        {
                            OnEmployeeSelected?.Invoke(this, employee);
                            ctrlEmployeeCard1.LoadTheData(employee);
                        }                    
                    }
                      
                }
                else
                {
                    clsEmployee employee = clsEmployee.Find(Convert.ToString(txtSearch.Text));
                    if (employee == null)
                        MessageBox.Show("Incorrect Information , Try Again");
                    else
                    {
                        OnEmployeeSelected?.Invoke(this, employee);
                        ctrlEmployeeCard1.LoadTheData(employee);
                    }
                }
            }            
            else
            {
                MessageBox.Show("The Search Box is Empty");
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddOrUpdateEmployee frm = new frmAddOrUpdateEmployee();
            frm.EmployeeAdded += EmployeeAdded;
            frm.ShowDialog();
        }
    }
}
