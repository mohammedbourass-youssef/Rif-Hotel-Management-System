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
using HACH_ME_EXEMPLE;
using Microsoft.VisualBasic.ApplicationServices;

namespace HotelManagementSystem.Users
{
    public partial class frmChangeUserName : Form
    {
        public enum EnMode { ByUser , ByAdmin }
        EnMode _mode;
        clsUser _user;
        public frmChangeUserName(clsUser user, EnMode mode)
        {
            InitializeComponent();
            _mode = mode;
            _user = user;
        }

        private void frmChangeUserName_Load(object sender, EventArgs e)
        {
            lblUserName.Text = _user.username;
            lblUserID.Text = _user.userID.ToString();
            if (_mode == EnMode.ByAdmin)
                txtPassword.PlaceholderText = "Admin Password";
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (_mode == EnMode.ByAdmin)
            {
                if (!string.IsNullOrEmpty(txtPassword.Text))
                {
                    if (clscryptography.ComputeHash(txtPassword.Text) != clsGlobal.current_user.password.Trim())
                    {
                        lblPasswordConfiguration.Visible = true;
                        lblPasswordConfiguration.Text = "Incorrect password. Please try again.";
                        lblPasswordConfiguration.ForeColor = Color.Red;
                        txtUserName.Enabled = false;
                        btnSave.Enabled = false;
                    }
                    else
                    {
                        lblPasswordConfiguration.Visible = true;
                        lblPasswordConfiguration.Text = "Password is valid.";
                        lblPasswordConfiguration.ForeColor = Color.Green;
                        txtUserName.Enabled = true;
                    }
                }
                else
                {
                    lblPasswordConfiguration.Visible = false;
                }
            }
            else
            {
                if (!string.IsNullOrEmpty(txtPassword.Text))
                {
                    if (clscryptography.ComputeHash(txtPassword.Text) != _user.password.Trim())
                    {
                        lblPasswordConfiguration.Visible = true;
                        lblPasswordConfiguration.Text = "Incorrect password. Please try again.";
                        lblPasswordConfiguration.ForeColor = Color.Red;
                        txtUserName.Enabled = false;
                        lblPasswordConfiguration.Enabled = false;
                        btnSave.Enabled = false;
                    }
                    else
                    {
                        lblPasswordConfiguration.Visible = true;
                        lblPasswordConfiguration.Text = "Password is valid.";
                        lblPasswordConfiguration.ForeColor = Color.Green;
                        txtUserName.Enabled = true;
                        lblPasswordConfiguration.Enabled = true;
                    }
                }
                else
                {
                    lblPasswordConfiguration.Visible = false;
                }
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
                    btnSave.Enabled = false;
                }
                else if (txtUserName.Text.Length < 4)
                {
                    lblUserNameExist.Visible = true;
                    lblUserNameExist.Text = "Invalid username. It must contain at least 4 characters.";
                    lblUserNameExist.ForeColor = Color.Red;
                    btnSave.Enabled = false;
                }
                else
                {
                    lblUserNameExist.Visible = true;
                    lblUserNameExist.Text = "Username is valid.";
                    lblUserNameExist.ForeColor = Color.Green;
                    btnSave.Enabled = true;
                }
            }
            else
            {
                lblUserNameExist.Visible = false;
                btnSave.Enabled = false;
            }
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUserName.Text))
            {
                if(_user.ChangeUserName(txtUserName.Text))
                {
                    lblUserName.Text = txtUserName.Text;
                    MessageBox.Show("UserName changed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to change the Username. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
