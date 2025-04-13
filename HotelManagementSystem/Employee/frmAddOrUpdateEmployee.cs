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
using HotelManagementSystem.Classes;
using HotelManagementSystem.People;

namespace HotelManagementSystem.Employee
{
    public partial class frmAddOrUpdateEmployee : Form
    {
        clsPerson _person = null;
        clsEmployee _employee = null;
        public event EventHandler<clsEmployee> EmployeeAdded;
        enum EnMode { Update , Addnew}
        public frmAddOrUpdateEmployee()
        {
            InitializeComponent();
            _mode = EnMode.Addnew;
        }
        public frmAddOrUpdateEmployee(int PersonID)
        {
            InitializeComponent();
            _mode = EnMode.Addnew;
            _person = clsPerson.Find(PersonID);
        }
        public frmAddOrUpdateEmployee(clsEmployee employee)
        {
            InitializeComponent();
            _mode = EnMode.Update;
            _employee = employee;
        }
        EnMode _mode; 
        void _MoveTheJumperToMe(Guna2Button button )
        {
            pnlJumper.BackColor = Color.White;
            pnlJumper.Size = new Size(button.Width,pnlHEader.Height - button.Height);
            pnlJumper.Top = button.Bottom -3;
            pnlJumper.Left = button.Left;   
        }
        ctrlFindAndPersonCard _findAndPersonCard = null;
        ctrlAddEmployeeInfo _addemployeeInfo = null;
        private void btnPersonInfo_Click_1(object sender, EventArgs e)
        {
            _MoveTheJumperToMe((Guna2Button)sender);
            pnlBody.Controls.Clear();
            _findAndPersonCard.Visible = true;
            _findAndPersonCard.Dock = DockStyle.Fill;   
            pnlBody.Controls.Add(_findAndPersonCard);
        }
        private void OnPersonSelected(object sender, clsPerson e)
        {
            _person = e;
        }
        private void btnEmployeeInfo_Click(object sender, EventArgs e)
        {
            _MoveTheJumperToMe((Guna2Button)sender);
            pnlBody.Controls.Clear();
            _addemployeeInfo.Visible = true;
            _addemployeeInfo.Dock = DockStyle.Fill;
            pnlBody.Controls.Add(_addemployeeInfo);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void OnEmployeeInfoAdded(object sender, OnEmployeeInfoUpdatedEventArgs e)
        {
            if(_mode == EnMode.Update)
            {
                _employee.salary = e.Salary;
                _employee.role = e.Role;
                if (_employee.Save())
                {
                    MessageBox.Show("Updated Succefully");
                    return;
                }
                else
                    MessageBox.Show("Unknowen Error , Please Contact Us To Fix it ");
                
            }
            else if(_mode == EnMode.Addnew)
            {
                if (_person == null)
                {
                    MessageBox.Show("Please Select Person Or Add One");
                    return;
                }
                if (_person != null)
                {
                    clsEmployee employee = new clsEmployee();
                    employee.createdbyuserID = clsGlobal.current_user;
                    employee.hiredate = e.HireDate;
                    employee.person = _person;
                    employee.salary = e.Salary;
                    employee.role = e.Role;
                    employee.firedate = null;
                    if (employee.Save())
                    {
                        MessageBox.Show("Employee Saved Succefully");
                        ctrlAddEmployeeInfo ctrl = (ctrlAddEmployeeInfo)sender;
                        ctrl.lbEmployeeID.Text =employee.Id.ToString();
                        EmployeeAdded?.Invoke(this,employee);
                    }
                    else
                        MessageBox.Show("Error Not Found, Check Why");
                }
            }            
        }
        private void frmAddOrUpdateEmployee_Load(object sender, EventArgs e)
        {
             _findAndPersonCard = new ctrlFindAndPersonCard();
          
            // 
            _addemployeeInfo = new ctrlAddEmployeeInfo();
            _addemployeeInfo.OnEmployeeInfoUpdated += OnEmployeeInfoAdded;
            if(_mode == EnMode.Update)
            {
                _addemployeeInfo.SetUpdateValues(_employee);
                _findAndPersonCard.LoadUpdateInfo(_employee.person);
                lblTitle.Text = "Update " + _employee.person.GetFullName() + " Employee Info";
                lblTitle.Location = new System.Drawing.Point(208, 1);
            } 
             else
             {
                if(_person != null)
                {
                     // to Add A person derectly from Manage People list
                    _findAndPersonCard.SetPersonAsEmployee(_person);
                    _addemployeeInfo.SetAddNewValues();
                }
                else
                {
                    // to Add 
                    _findAndPersonCard.LoadTheCtrl();
                    _findAndPersonCard.OnPersonSelected += OnPersonSelected;
                    _addemployeeInfo.SetAddNewValues();
                }
             }
                
                 btnPersonInfo_Click_1(btnPersonInfo, e);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
