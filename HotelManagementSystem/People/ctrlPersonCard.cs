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
using HotelManagementSystem.Properties;

namespace HotelManagementSystem.People
{
    public partial class ctrlPersonCard : UserControl
    {
        public ctrlPersonCard()
        {
            InitializeComponent();
        }
        void _SetPicture(string picpath ,EnGender gender)
        {
            if (String.IsNullOrEmpty(picpath))
            {
                if(gender == EnGender.Female)
                {
                    pbProfile.Image = Resources.WomanBlank;
                }
                else
                {
                    pbProfile.Image = Resources.UserManBlank;

                }
            }
            else
            {
                pbProfile.ImageLocation = picpath;
            }
        }
        public void SetInfo(clsPerson person)
        {
            lblPersonID.Text = person.PersonID.ToString();
            lblFirstName.Text = person.FirstName.ToString().Trim();
            lblLastName.Text = person.LastName.ToString().Trim();
            lblSecondName.Text = person.SecondName.ToString().Trim();
            lblCountry.Text = person.country.CountryName.Trim();
            if (!string.IsNullOrEmpty(person.email))
                lblEmail.Text = person.email.Trim();
            else
                lblEmail.Text = "Unvailable";
            lblPhone.Text = person.phone.Trim();
            lblNationnalNo.Text = person.nationnalnumber.Trim();
            lblPassportNo.Text = person.passportnumber.Trim();
            lblGender.Text = person.gender.ToString().Trim();
           if(person.CreatedByUser == null)
            {
                lblUser.Text = "NoOne";
            }
           else
            {
                lblUser.Text = person.CreatedByUser.username.Trim();
            }
            _SetPicture(person.picturepath, person.gender);
        }

        private void gunaGroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void pbProfile_Click(object sender, EventArgs e)
        {

        }

        private void lblPhone_Click(object sender, EventArgs e)
        {

        }
    }
}
