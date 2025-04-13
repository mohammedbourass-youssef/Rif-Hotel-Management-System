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
using HotelManagementSystem.Employee;

namespace HotelManagementSystem.People
{
    public partial class frmManagePeople : Form
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
        public frmManagePeople()
        {
            InitializeComponent();
        }
        enum EnFilterItem {
            None,PersonID,FullName,NationnalNumber,PassportNumber,Country
        }
        EnFilterItem _currentfilter = EnFilterItem.None;
        void _LoadAllData()
        {
            cmFilter.SelectedIndex = 0;
            dgvAllPeople.DataSource = clsPerson.RetrieveAllPeopleForManagePeople();
        
        }
        bool IsExist(string i)
        {
            foreach(string item in cmCountries.Items)
            {
                if(i == item) return true;
            }
            return false;
        }
        private void frmManagePeople_Load(object sender, EventArgs e)
        {
            _LoadAllData();
            DataTable dt = clsPerson.RetrieveAllPeopleForManagePeople();
            foreach (DataRow dr in dt.Rows)
            {
                if (!IsExist(dr[6].ToString().Trim()))
                    cmCountries.Items.Add(dr[6].ToString().Trim());
                
            }
            cmCountries.SelectedIndex = 0;
        }

        private void cmFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSearch.Text = string.Empty;
            switch (cmFilter.SelectedIndex)
            {
                case 0:_currentfilter = EnFilterItem.None;
                    cmCountries.Visible = false;
                    txtSearch.Visible = false;
                    _LoadAllData();
                    break;
                case 1:_currentfilter = EnFilterItem.PersonID; 
                    cmCountries.Visible = false;
                    txtSearch.Visible = true;
                    break;
                case 2 :_currentfilter = EnFilterItem.FullName; 
                    cmCountries.Visible = false;
                    txtSearch.Visible = true;
                    break;
                case 3: _currentfilter = EnFilterItem.NationnalNumber;
                    cmCountries.Visible = false;
                    txtSearch.Visible = true;
                    break;
                case 4:
                    _currentfilter = EnFilterItem.PassportNumber;
                    cmCountries.Visible = false;
                    txtSearch.Visible = true;
                    break;
                case 5: _currentfilter = EnFilterItem.Country;
                    cmCountries.Visible = true;
                    txtSearch.Visible = false;
                    break;
                
            }
        }

        private void cmCountries_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable table = clsPerson.RetrieveAllPeopleForManagePeople();
            if (_currentfilter == EnFilterItem.Country)
            {
                DataView view = table.DefaultView;
                view.RowFilter = cmFilter.Text + " = '" + cmCountries.Text + "'";
                dgvAllPeople.DataSource = view;
            }
        }

        private void txtSearch_Validating(object sender, CancelEventArgs e)
        {
           
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(_currentfilter == EnFilterItem.PersonID)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true; // Block the input
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataTable table = clsPerson.RetrieveAllPeopleForManagePeople();
            if (!string.IsNullOrEmpty(txtSearch.Text))
            {
               if(_currentfilter != EnFilterItem.PersonID)
                {
                    DataView view = table.DefaultView;
                    view.RowFilter ="["+ cmFilter.Text +"] LIKE '" + txtSearch.Text + "%'";
                    dgvAllPeople.DataSource = view;
                }
              
               else
                {
                    DataView view = table.DefaultView;
                    view.RowFilter = cmFilter.Text +" = '" +txtSearch.Text + "'";
                    dgvAllPeople.DataSource = view;
                }
            }
            else
            {
                _LoadAllData();
            }
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            frmAddOrUpdatePerson frm = new frmAddOrUpdatePerson();
            frm.ShowDialog();
            _LoadAllData();
        }

        private void dgvAllPeople_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmShowPersonDetails showPersonDetails = new frmShowPersonDetails((int)dgvAllPeople.CurrentRow.Cells[0].Value);
            showPersonDetails.ShowDialog();
        }
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            clsPerson person = clsPerson.Find((int)dgvAllPeople.CurrentRow.Cells[0].Value);
            if (person != null)
            {
                frmAddOrUpdatePerson UpdatePerson = new frmAddOrUpdatePerson(person);
                UpdatePerson.ShowDialog();
            }
            _LoadAllData();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            frmShowPersonDetails showPersonDetails = new frmShowPersonDetails((int)dgvAllPeople.CurrentRow.Cells[0].Value);
            showPersonDetails.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are sure you want to Delete this  person? ", "Attention", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                clsPerson.Delete((int)dgvAllPeople.CurrentRow.Cells[0].Value);
                _LoadAllData();  
            }
        }

        private void g_Opening(object sender, CancelEventArgs e)
        {
            if (clsEmployee.IsExist((int)dgvAllPeople.CurrentRow.Cells[0].Value))
            {
                SetAsEmployee.Enabled = false;
                setGuests.Enabled = false;
            }
            else
            {
                SetAsEmployee.Enabled = true;
                setGuests.Enabled = true;
            }
        }

        private void SetAsEmployee_Click(object sender, EventArgs e)
        {
            frmAddOrUpdateEmployee frm = new frmAddOrUpdateEmployee((int)dgvAllPeople.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _LoadAllData();
        }
    }
}
