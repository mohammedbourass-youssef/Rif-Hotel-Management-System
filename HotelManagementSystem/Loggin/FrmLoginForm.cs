using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusnessLayer;
using Guna.UI2.WinForms;
using HACH_ME_EXEMPLE;
using HotelManagementSystem.Classes;
using HotelManagementSystem.Properties;
using Microsoft.Win32;
using static System.Net.Mime.MediaTypeNames;

namespace HotelManagementSystem
{
    public partial class FrmLoginForm : Form
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

        enum EnPasswordState { Hide , Show }
        public FrmLoginForm()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            SetRoundedRegion(30); // Call function to make the form rounded
        }
        //Varibles : 
        EnPasswordState _passwordState = EnPasswordState.Hide;
        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        void _GetIfRemmber()
        {
            string str = clsRegistryAndLog.ReadFromRegistry(clsGlobal.RegistryName);
            if (str != null)
            {
                if(str != clsGlobal.DontRemmeberMeString)
                {
                    string[] result = str.Split(new string[] { "//##//" }, StringSplitOptions.None);
                    txtUserName.Text = clscryptography.Decrypt(result[0],clsGlobal.Key);
                    txtPassword.Text = clscryptography.Decrypt(result[1], clsGlobal.Key);
                    RemmberME.Checked = true;
                }
            }
        }
        private void FrmLoginForm_Load(object sender, EventArgs e)
        {
            KeyPreview = true;
            _GetIfRemmber();
            clsReservation.CancelNonCheckInReservations();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to Cancel ? ", "Attention", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1,
                MessageBoxOptions.RightAlign) == DialogResult.OK)
                this.Close();
        }


        private void btnShowPassword_Click(object sender, EventArgs e)
        {
            if(_passwordState == EnPasswordState.Hide)
            {
                btnShowPassword.Image = Resources.icons8_closed_eye_64;
                _passwordState = EnPasswordState.Show;
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                btnShowPassword.Image = Resources.icons8_eye_40;
                _passwordState = EnPasswordState.Hide;
                txtPassword.PasswordChar = '*';
            }
            txtPassword.Focus();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassword.Text) || string.IsNullOrEmpty(txtUserName.Text))
            {
                MessageBox.Show("Username or password cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                clsGlobal.current_user = clsUser.Find(txtUserName.Text.Trim());
                if (clsGlobal.current_user != null)
                {
                    if (clsGlobal.current_user.IsActive)
                    {
                        if (clscryptography.ComputeHash(txtPassword.Text) == clsGlobal.current_user.password.Trim())
                        {
                            if (RemmberME.Checked)
                            {
                                clsRegistryAndLog.WriteToRegistry(clsGlobal.RegistryName,
                                clscryptography.Encrypt(txtUserName.Text, clsGlobal.Key) + "//##//" +
                                clscryptography.Encrypt(txtPassword.Text, clsGlobal.Key));
                            }
                            else
                            {
                                clsRegistryAndLog.WriteToRegistry(clsGlobal.RegistryName, clsGlobal.DontRemmeberMeString);
                            }
                            this.Hide();
                            frmMainForm frm = new frmMainForm();
                            frm.ShowDialog();
                            this.Show();
                        }
                        else
                        {
                            MessageBox.Show("Incorrect username or password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Your account has been blocked. Please contact the administrator.", "Account Blocked", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Incorrect username or password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {
           RemmberME.Checked = !RemmberME.Checked;
        }

        private void FrmLoginForm_KeyDown(object sender, KeyEventArgs e)
        {
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                guna2GradientButton1.PerformClick();// Simulate a button click
                return true; // Prevent default behavior (focus change)
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

    }
}
