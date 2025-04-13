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

namespace HotelManagementSystem.Guests
{
    public partial class frmAddNewGuest : Form
    {
        public event EventHandler<int> OnNewGuestsAdded;
        clsPerson _person;
        enum EnMode { SendByPerson , AddByNewButton}
        EnMode _mode;
        public frmAddNewGuest()
        {
            InitializeComponent();
            _mode = EnMode.AddByNewButton;
        }
        public frmAddNewGuest(clsPerson person)
        {
            InitializeComponent();
            _mode = EnMode.SendByPerson;
            this._person = person;
        }

        private void ctrlFindAndPersonCard1_OnPersonSelected(object sender, BusnessLayer.clsPerson e)
        {
            _person = e;
            btnSave.Enabled = true;
        }

        private void frmAddNewGuest_Load(object sender, EventArgs e)
        {
            if(_mode == EnMode.SendByPerson)
            {
                btnSave.Enabled = false;
                ctrlFindAndPersonCard1.LoadUpdateInfo(_person);
            }       
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_person != null)
            {
                if (MessageBox.Show("Do you want to add this person as a guest?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    clsGuests guests = new clsGuests();
                    guests.person = _person;
                    if (guests.Save())
                    {
                        MessageBox.Show("Saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        OnNewGuestsAdded?.Invoke(this, guests.guestsID);
                    }                     
                    else
                        MessageBox.Show("An error occurred while saving.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
}
