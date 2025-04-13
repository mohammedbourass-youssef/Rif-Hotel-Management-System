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
    public partial class ctrlEmployeeCard : UserControl
    {
        public ctrlEmployeeCard()
        {
            InitializeComponent();
        }
        public void LoadTheData(clsEmployee employee) {
            ctrlPersonCard1.SetInfo(employee.person);
            lblEmployeeID.Text = employee.Id.ToString();
            lblSalary.Text = employee.salary.ToString();
            lblHireDate.Text = employee.hiredate.ToString("dd-MMMM-yyyy");
            lblFireDate.Text = (employee.firedate == null) ?"Hiring Employee" : employee.firedate?.ToString("dd-MMMM-yyyy");   
            lblUser.Text = (employee.createdbyuserID == null)?"Admin":employee.createdbyuserID.username.ToString();
            lblRole.Text = employee.role.Rolename;
        }
    }
}
