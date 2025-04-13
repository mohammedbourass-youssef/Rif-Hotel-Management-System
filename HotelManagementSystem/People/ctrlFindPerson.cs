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

namespace HotelManagementSystem.People
{
    public partial class ctrlFindPerson : UserControl
    {
       
        public ctrlFindPerson()
        {
            InitializeComponent();
        }
        public event EventHandler<clsPerson> BackedData;
        enum EnFilterItem
        {
            None, PersonID, NationnalNumber, PassportNumber
        }

        EnFilterItem _currentfilter = EnFilterItem.None;
        private void GetDataForNewPErson(object sender,clsPerson clsPerson)
        {
            frmAddOrUpdatePerson frm = (frmAddOrUpdatePerson)sender;
            frm.Close();
            this.BackedData.Invoke(this,clsPerson);
        }
        public void LoadData()
        {
            cmFilter.SelectedIndex = 0;
        }
        private void cmFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSearch.Text = string.Empty;
            switch (cmFilter.SelectedIndex)
            {
                case 0:
                    _currentfilter = EnFilterItem.None;
                    break;
                case 1:
                    _currentfilter = EnFilterItem.PersonID;
                    break;
                case 2:
                    _currentfilter = EnFilterItem.NationnalNumber;
                    break;
                case 3:
                    _currentfilter = EnFilterItem.PassportNumber;
                    break;
            }
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            frmAddOrUpdatePerson frmAddOrUpdatePerson = new frmAddOrUpdatePerson();
            frmAddOrUpdatePerson.BackedData += GetDataForNewPErson;
            frmAddOrUpdatePerson.ShowDialog();
        }
        clsPerson _Find()
        {
            switch (_currentfilter)
            {
                case EnFilterItem.PersonID:return clsPerson.Find(int.Parse(txtSearch.Text));
                case EnFilterItem.NationnalNumber:return clsPerson.Find(txtSearch.Text);
                case EnFilterItem.PassportNumber: return clsPerson.FindByPassportNumber(txtSearch.Text);
                default:return null;
            }
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            clsPerson person = _Find();
            if (person != null)
            {
                BackedData?.Invoke(this, person);
            }
            else
            {
                MessageBox.Show("Person Not Found Try Again");
            }
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (_currentfilter == EnFilterItem.PersonID)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }
    }
}
