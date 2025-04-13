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

namespace HotelManagementSystem.Users
{
    public partial class frmChangePassword : Form
    {
        clsUser user = null;
        public enum EnMode { ByAdmin , ByUser}
        EnMode _mode = EnMode.ByAdmin;
        public frmChangePassword(clsUser user , EnMode mode)
        {

            InitializeComponent();
            this.user = user;
            _mode = mode;
        }

        private void frmChangePassword_Load(object sender, EventArgs e)
        {
            lblUserID.Text = user.userID.ToString();
            lblUserName.Text = user.username.ToString();
            if (_mode == EnMode.ByAdmin)
                txtOldPassword.PlaceholderText = "Admin Password";
        }

        private void txtOldPassword_TextChanged(object sender, EventArgs e)
        {
            if(_mode == EnMode.ByAdmin)
            {
                if (!string.IsNullOrEmpty(txtOldPassword.Text))
                {
                    if (clscryptography.ComputeHash(txtOldPassword.Text) != clsGlobal.current_user.password.Trim())
                    {
                        lblOldPasswordConfiguration.Visible = true;
                        lblOldPasswordConfiguration.Text = "Incorrect password. Please try again.";
                        lblOldPasswordConfiguration.ForeColor = Color.Red;
                        txtPassword.Enabled = false;
                        txtConfirmPassword.Enabled = false;
                        btnSave.Enabled = false;
                    }
                    else
                    {
                        lblOldPasswordConfiguration.Visible = true;
                        lblOldPasswordConfiguration.Text = "Password is valid.";
                        lblOldPasswordConfiguration.ForeColor = Color.Green;
                        txtPassword.Enabled = true;
                        txtConfirmPassword.Enabled = true;
                    }
                }
                else
                {
                    lblOldPasswordConfiguration.Visible = false;
                }
            }
            else
            {
                if (!string.IsNullOrEmpty(txtOldPassword.Text))
                {
                    if (clscryptography.ComputeHash(txtOldPassword.Text) != user.password.Trim())
                    {
                        lblOldPasswordConfiguration.Visible = true;
                        lblOldPasswordConfiguration.Text = "Incorrect password. Please try again.";
                        lblOldPasswordConfiguration.ForeColor = Color.Red;
                        txtPassword.Enabled = false;
                        txtConfirmPassword.Enabled = false;
                        btnSave.Enabled = false;
                    }
                    else
                    {
                        lblOldPasswordConfiguration.Visible = true;
                        lblOldPasswordConfiguration.Text = "Password is valid.";
                        lblOldPasswordConfiguration.ForeColor = Color.Green;
                        txtPassword.Enabled = true;
                        txtConfirmPassword.Enabled = true;
                    }
                }
                else
                {
                    lblOldPasswordConfiguration.Visible = false;
                }
            }
        }

        private void txtConfirmPassword_TextChanged(object sender, EventArgs e)
        {
           
            if (!string.IsNullOrEmpty(txtPassword.Text))
            {
                if (txtConfirmPassword.Text != txtPassword.Text)
                {
                    lblConfirmPasswordConfigirations.Visible = true;
                    lblConfirmPasswordConfigirations.Text = "Password and Confirm Password do not match. Please try again.";
                    lblConfirmPasswordConfigirations.ForeColor = Color.Red;
                   
                }
                else
                {
                    lblConfirmPasswordConfigirations.Visible = true;
                    lblConfirmPasswordConfigirations.Text = "Passwords match.";
                    lblConfirmPasswordConfigirations.ForeColor = Color.Green;
                    btnSave.Enabled = true;
                }
            }
            else
            {
                lblConfirmPasswordConfigirations.Visible = false;
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPassword.Text))
            {
                if (clscryptography.ComputeHash(txtPassword.Text) == user.password.Trim())
                {
                    lblNewPasswordConfiguration.Visible = true;
                    lblNewPasswordConfiguration.Text = "New password cannot be the same as the old password.";
                    lblNewPasswordConfiguration.ForeColor = Color.Red;
                    btnSave.Enabled = false;
                }
                else
                {
                    lblNewPasswordConfiguration.Visible = true;
                    lblNewPasswordConfiguration.Text = "Password is valid.";
                    lblNewPasswordConfiguration.ForeColor = Color.Green;
                    
                }
            }
            else
            {
                lblNewPasswordConfiguration.Visible = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (user.ChangePassword(clscryptography.ComputeHash(txtConfirmPassword.Text)))
            {
                MessageBox.Show("Password changed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed to change the password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
