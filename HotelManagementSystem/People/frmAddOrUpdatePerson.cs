using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusnessLayer;
using Guna.UI2.WinForms;
using HotelManagementSystem.Classes;
using HotelManagementSystem.Properties;
using Microsoft.Win32;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace HotelManagementSystem.People
{
    public partial class frmAddOrUpdatePerson : Form
    {
        //private void SetRoundedRegion(int radius)
        //{
        //    GraphicsPath path = new GraphicsPath();
        //    int d = radius * 2;
        //    Rectangle rect = this.ClientRectangle;

        //    // Create arcs for rounded corners
        //    path.AddArc(rect.X, rect.Y, d, d, 180, 90);
        //    path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90);
        //    path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90);
        //    path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90);

        //    path.CloseFigure();
        //    this.Region = new Region(path); // Apply rounded region
        //}
        //protected override void OnLoad(EventArgs e)
        //{
        //    base.OnLoad(e);
        //    SetRoundedRegion(30); // Call function to make the form rounded
        //}

        public event EventHandler<clsPerson> BackedData;
        public frmAddOrUpdatePerson()
        {
            InitializeComponent();
            _mode = EnMode.AddNew;
        }
        public frmAddOrUpdatePerson(clsPerson person)
        {
            InitializeComponent();
            _mode = EnMode.Update;
            _oldperson = person;
            _x = false;
        }

        public frmAddOrUpdatePerson(clsPerson person,bool x)
        {
            InitializeComponent();
            _mode = EnMode.Update;
            _oldperson = person;
            _x = x; 
        }
        enum EnMode {Update , AddNew }
        EnMode _mode = EnMode.Update;
        EnGender _gender;
        clsPerson _oldperson = null;
        string _profilepath = null;
        bool _ischanged=false;
        void _SetPicture()
        {
            if (string.IsNullOrEmpty(_profilepath))
            {
                if (_gender == EnGender.Female)
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
                pbProfile.ImageLocation = _profilepath;
            }
        }
        void _LoadAllCountries()
        {

            DataTable dt = clsCountry.RetreiveAllCountries();
            foreach (DataRow dr in dt.Rows)
            {
                cmCountries.Items.Add(dr[0].ToString().Trim());
            }
        }

        void _SetInfo()
        {
            lbPersonID.Text =_oldperson.PersonID.ToString();
            txtFirstName.Text = _oldperson.FirstName.Trim();
            txtSecondName.Text = _oldperson.SecondName.Trim();
            txtLastName.Text = _oldperson.LastName.Trim();
            if(!string.IsNullOrEmpty(_oldperson.email))
                txtEmail.Text = _oldperson.email.Trim();
            txtPhone.Text = _oldperson.phone.Trim();
            cmCountries.SelectedIndex = _oldperson.country.CountryId-1;
            if (!string.IsNullOrEmpty(_oldperson.nationnalnumber) && _oldperson.nationnalnumber != "Unvailable")
                txtNationnalNumber.Text = _oldperson.nationnalnumber.Trim();
            if (!string.IsNullOrEmpty(_oldperson.passportnumber) && _oldperson.passportnumber != "Unvailable")
                txtPassportNumber.Text = _oldperson.passportnumber;
            _profilepath = _oldperson.picturepath;
            _SetPicture();
            _gender = _oldperson.gender;
            if (_gender == EnGender.Male)
                rbMale.Checked = true;
            else
                rbFemale.Checked = true;
        }


        void _UpdatePerson()
        {
            _oldperson.FirstName = txtFirstName.Text;
            _oldperson.SecondName = txtSecondName.Text;
            _oldperson.LastName = txtLastName.Text;
            _oldperson.email = txtEmail.Text;
            _oldperson.phone = txtPhone.Text;
            _oldperson.country = clsCountry.Find(cmCountries.Text);
            _oldperson.nationnalnumber = txtNationnalNumber.Text;
            _oldperson.passportnumber = txtPassportNumber.Text;
            _oldperson.picturepath = _profilepath; 
            _oldperson.gender = _gender;
            if (!string.IsNullOrEmpty(_profilepath))
            {
                if (_ischanged)
                {
                    Image image = Image.FromFile(_profilepath);
                    string guid = Guid.NewGuid().ToString();
                    _oldperson.picturepath = ConfigurationManager.AppSettings["DestinationFolder"] + guid + ".png";
                    image.Save(_oldperson.picturepath, ImageFormat.Png);
                }
            }
            else
            {
                _oldperson.picturepath = string.Empty;
            }
            if (MessageBox.Show("Are sure you want to save this new person? ", "Attention", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand) == DialogResult.OK)
            {
                if (_oldperson.Save())
                {
                    MessageBox.Show("Saved Succefully");

                }
            }
        }

        void _AddNewPerson()
        {
            if (!Directory.Exists(ConfigurationManager.AppSettings["DestinationFolder"]))
            {
                Directory.CreateDirectory(ConfigurationManager.AppSettings["DestinationFolder"]);
            }
            clsPerson newperson = new clsPerson();
            if (!string.IsNullOrEmpty(_profilepath))
            {
                
                    Image image = Image.FromFile(_profilepath);
                    string guid = Guid.NewGuid().ToString();
                    newperson.picturepath = ConfigurationManager.AppSettings["DestinationFolder"] + guid + ".png";
                    image.Save(newperson.picturepath, ImageFormat.Png);
                
            }
            else
            {
                newperson.picturepath = string.Empty;
            }
            newperson.FirstName = txtFirstName.Text;
            newperson.LastName = txtLastName.Text;
            newperson.SecondName = txtSecondName.Text;
            newperson.phone = txtPhone.Text;
            newperson.email = txtEmail.Text;
            if (!string.IsNullOrEmpty(txtNationnalNumber.Text))
            {
                if (!clsPerson.IsExistsByNationnalNumber(txtNationnalNumber.Text))
                    newperson.nationnalnumber = txtNationnalNumber.Text;
                else
                    MessageBox.Show("This Nationnal Number Already exist");
            }
            if (!string.IsNullOrEmpty(txtPassportNumber.Text))
            {
                if (!clsPerson.IsExistsByNationnalNumber(txtPassportNumber.Text))
                    newperson.passportnumber = txtPassportNumber.Text;
                else
                    MessageBox.Show("This Nationnal Number Already exist");
            }
            
            newperson.CreatedByUser = clsGlobal.current_user;
            newperson.gender = _gender;
            newperson.country = clsCountry.Find(cmCountries.Text.Trim());
            if(MessageBox.Show("Are sure you want to save this new person? ", "Attention", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand) == DialogResult.OK)
            {
                if (newperson.Save())
                {
                    MessageBox.Show("Saved Succefully");
                    lbPersonID .Text = newperson.PersonID.ToString();
                    BackedData?.Invoke(this, newperson);    
                }
            }
        }
        bool _x;
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true; // Block the input
            }
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtEmail.Text))
            {
                if (!clsOtils.IsValidEmail(txtEmail.Text))
                {
                    e.Cancel = true;
                    txtEmail.Focus();
                    ErrControlEmpty.SetError(txtEmail, "Invalid Email");
                }
                else
                {
                    e.Cancel = false;
                    ErrControlEmpty.SetError(txtEmail, "");
                }
            }
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Block the input
            }
        }

        private void txtFirstName_Validating(object sender, CancelEventArgs e)
        {
            Guna2TextBox textBox = (Guna2TextBox)sender;
            if (string.IsNullOrEmpty(textBox.Text))
            {
               
                    e.Cancel = true;
                    txtEmail.Focus();
                    ErrControlEmpty.SetError(textBox,textBox.PlaceholderText + " Required");             
            }
            else
            {
                e.Cancel = false;
                ErrControlEmpty.SetError(textBox, "");
            }
        }

        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {
            _gender = EnGender.Male;
            _SetPicture();
        }

        private void rbFemale_CheckedChanged(object sender, EventArgs e)
        {
            _gender  = EnGender.Female;
            _SetPicture();
        }

        private void frmAddOrUpdatePerson_Load(object sender, EventArgs e)
        {
            btnCancel.Visible = !_x;
            rbMale.Checked = true;
            _gender = EnGender.Male;
            _SetPicture();
            _LoadAllCountries();
            if(_mode == EnMode.Update)
            {
                _SetInfo();
                if (!string.IsNullOrEmpty(_profilepath))
                {
                    lklblSetImage.Location = new Point(774, 374);
                    lkLblDeleteImage.Visible = true;
                }
 
                lbltitle.Text = "Update " + _oldperson.GetFullName() + " Info";
                lbltitle.Location = new Point(223, 0);
            }
                
        }

        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void lklblSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        { 
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pbProfile.ImageLocation = openFileDialog1.FileName;
                _profilepath = openFileDialog1.FileName.ToString();
                lklblSetImage.Location = new Point(774, 374);
                lkLblDeleteImage.Visible = true;
                _ischanged = true;
            }
        }

        private void lkLblDeleteImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!string.IsNullOrEmpty(_profilepath) && _mode == EnMode.Update)
            {
                File.Delete(_profilepath);
            }
            lklblSetImage.Location = new Point(877, 374);
            lkLblDeleteImage.Visible = false;
            _profilepath = null;
            _SetPicture();
           
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_mode == EnMode.AddNew)
            {
                _AddNewPerson();
            }
            else
            {
                _UpdatePerson();
            }
        }

        private void txtNationnalNumber_Validating(object sender, CancelEventArgs e)
        {

        }

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void rbMale_CheckedChanged_1(object sender, EventArgs e)
        {
            rbMale_CheckedChanged(sender, e);
        }

        private void rbFemale_CheckedChanged_1(object sender, EventArgs e)
        {
            rbFemale_CheckedChanged(sender,e);
        }

        private void lklblSetImage_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lklblSetImage_LinkClicked(sender, e);
        }

        private void lkLblDeleteImage_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lkLblDeleteImage_LinkClicked(sender, e);
        }

        private void guna2GradientPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
