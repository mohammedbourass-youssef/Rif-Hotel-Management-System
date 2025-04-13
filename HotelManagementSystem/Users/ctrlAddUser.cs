using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusnessLayer;
using HotelManagementSystem.Classes;
using HotelManagementSystem.Properties;

namespace HotelManagementSystem.Users
{
    public partial class ctrlAddUser : UserControl
    {
        public event EventHandler<OnSaveClickedAddedUSerEventArgs> OnSaveClicked;
        public ctrlAddUser()
        {
            InitializeComponent();
        }
        int permissions;
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserName.Text) || string.IsNullOrEmpty(txtPassword.Text) || string.IsNullOrEmpty(txtConfirmPassword.Text) || permissions == 0)
            {
                MessageBox.Show("Invalid input , try Again");
            }
            else
            {
                if (!clsUser.IsExist(txtUserName.Text))
                {
                    if (txtConfirmPassword.Text != txtPassword.Text)
                    {
                        MessageBox.Show("Boxes Of PAsswords are not the Same");
                    }
                    else
                    {
                        OnSaveClicked?.Invoke(this, new OnSaveClickedAddedUSerEventArgs(txtUserName.Text.Trim(), txtPassword.Text.Trim(), permissions));
                    }
                }
                else
                {
                    MessageBox.Show("This UserName Has taken");
                }
            }
        }
        private void chAllPermissions_Click(object sender, EventArgs e)
        {
            CheckBox box = (CheckBox)sender;
            if (box == chAllPermissions)
            {
                if (box.Checked)
                {
                    permissions = -1;
                    ManageGuets.Enabled = false;
                    ManageGuets.Checked = false;
                    ManageEmployees.Enabled = false;
                    ManageEmployees.Checked = false;
                    ManageUsers.Enabled = false;
                    ManageUsers.Checked = false;
                    ManagePayement.Enabled = false;
                    ManagePayement.Checked = false;
                    ManageReservations.Enabled = false;
                    ManageReservations.Checked = false;
                    ManagePeople.Enabled = false;
                    ManagePeople.Checked = false;
                    chManageRooms.Enabled = false;
                    chManageRooms.Checked = false;
                }
                else
                {
                    permissions = 0;
                    ManageGuets.Enabled = true;
                    ManageUsers.Enabled = true;
                    ManagePayement.Enabled = true;
                    ManageReservations.Enabled = true;
                    ManagePeople.Enabled = true;
                    chManageRooms.Enabled = true;
                }
            }
            else
            {
                if (box.Checked)
                    permissions += int.Parse(box.Tag.ToString());
                else
                    permissions -= int.Parse(box.Tag.ToString());

            }
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUserName.Text))
            {
                if (clsUser.IsExist(txtUserName.Text))
                {
                    lblUserNameExist.Visible = true;
                    lblUserNameExist.Text = $"'{txtUserName.Text}' is already taken. Please choose another username.";
                    lblUserNameExist.ForeColor = Color.Red;
                }
                else if (txtUserName.Text.Length < 4)
                {
                    lblUserNameExist.Visible = true;
                    lblUserNameExist.Text = "Invalid username. It must contain at least 4 characters.";
                    lblUserNameExist.ForeColor = Color.Red;
                }
                else
                {
                    lblUserNameExist.Visible = true;
                    lblUserNameExist.Text = "Username is valid.";
                    lblUserNameExist.ForeColor = Color.Green;
                }
            }
            else
            {
                lblUserNameExist.Visible = false;
            }
        }
        enum EnPasswordState { Hide, Show }
        EnPasswordState _passwordState = EnPasswordState.Hide;
        private void btnShowPassword_Click(object sender, EventArgs e)
        {
            if (_passwordState == EnPasswordState.Hide)
            {
                btnShowPassword.Image = Resources.icons8_closed_eye_64;
                _passwordState = EnPasswordState.Show;
                txtPassword.PasswordChar = '\0';
                txtConfirmPassword.PasswordChar = '\0';
            }
            else
            {
                btnShowPassword.Image = Resources.icons8_eye_40;
                _passwordState = EnPasswordState.Hide;
                txtPassword.PasswordChar = '*';
                txtConfirmPassword.PasswordChar = '*';
            }
            txtPassword.Focus();
        }

        private void txtConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lblConfPassword.Text))
            {
                if (txtConfirmPassword.Text != txtPassword.Text)
                {
                    lblConfPassword.Visible = true;
                    lblConfPassword.Text = "Password and Confirm Password do not match. Please try again.";
                    lblConfPassword.ForeColor = Color.Red;
                }
                else
                {
                    lblConfPassword.Visible = true;
                    lblConfPassword.Text = "Passwords match.";
                    lblConfPassword.ForeColor = Color.Green;
                }
            }
            else
            {
                lblConfPassword.Visible = false;
            }

        }
    } 
}
