using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusnessLayer;

namespace HotelManagementSystem.People
{
    public partial class frmShowPersonDetails : Form
    {
        clsPerson person;
        public frmShowPersonDetails(int personID)
        {
            person = clsPerson.Find(personID);
            InitializeComponent();
        }

        private void frmShowPersonDetails_Load(object sender, EventArgs e)
        {
            ctrlPersonCard1.SetInfo(person);
            lblName.Text = person.GetFullName();
        }

        private void ctrlPersonCard1_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gunaLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
