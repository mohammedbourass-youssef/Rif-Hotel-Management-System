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
    public partial class frmSelectPerson : Form
    {
        clsPerson _person = null;
        public event EventHandler<clsPerson> OnPersonSelected;
        public frmSelectPerson()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSa_Click(object sender, EventArgs e)
        {
            if (_person != null)
            {
                 OnPersonSelected?.Invoke(this, _person);
                this.Close();
            }
            else
                MessageBox.Show("Please Select Person First");
        }

        private void ctrlFindAndPersonCard1_OnPersonSelected(object sender, BusnessLayer.clsPerson e)
        {
            _person = e;
           
        }

        private void frmSelectPerson_Load(object sender, EventArgs e)
        {
            ctrlFindAndPersonCard1.SetAsGuestFinder();
        }
    }
}
