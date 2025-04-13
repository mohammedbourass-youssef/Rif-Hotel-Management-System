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

namespace HotelManagementSystem.Users
{
    public partial class frmManageUsers : Form
    {
        enum EnFilter
        {
            None,
            ID,
            UserName,
            FullName
        }
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
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            SetRoundedRegion(30); // Call function to make the form rounded
        }
        public frmManageUsers()
        {
            InitializeComponent();
        }
        EnFilter _filter = EnFilter.None;
        void _LoadAllUsers()
        {
            dgvAllUsers.DataSource = clsUser.GetAllUser();
        }
        private void frmManageUsers_Load(object sender, EventArgs e)
        {
            _LoadAllUsers();
            cmFilter.SelectedIndex = 0;
        }

        private void cmFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            _LoadAllUsers();
          
            //Logic
            txtSearch.Text = string.Empty;
            switch (cmFilter.SelectedIndex)
            {
                case 0:
                    _filter = EnFilter.None;
                    txtSearch.Visible = false;
                    break;
                case 1:
                    _filter = EnFilter.ID;
                    txtSearch.Visible = true;
                    break;
                case 2:
                    _filter = EnFilter.UserName;
                    txtSearch.Visible = true;
                    break;
                case 3:
                    _filter = EnFilter.FullName;
                    txtSearch.Visible = true;
                    break;
            }
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (_filter == EnFilter.ID)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true; // Block the input
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataTable table = clsUser.GetAllUser();
            if (!string.IsNullOrEmpty(txtSearch.Text))
            {
                if (_filter != EnFilter.ID)
                {
                    DataView view = table.DefaultView;
                    view.RowFilter = "[" + cmFilter.Text + "] LIKE '" + txtSearch.Text + "%'";
                    dgvAllUsers.DataSource = view;
                }
                else if (_filter == EnFilter.ID)
                {
                    DataView view = table.DefaultView;
                    view.RowFilter = cmFilter.Text + " = '" + txtSearch.Text + "'";
                    dgvAllUsers.DataSource = view;
                }     
            }
            else
            {
                _LoadAllUsers();
            }
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            clsUser user = clsUser.Find((int)dgvAllUsers.CurrentRow.Cells[0].Value);
            frmUserDetails frmUser = new frmUserDetails(user);
            frmUser.ShowDialog();
        }

        private void dgvAllUsers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            clsUser user = clsUser.Find((int)dgvAllUsers.CurrentRow.Cells[0].Value);
            frmUserDetails frmUser = new frmUserDetails(user);
            frmUser.ShowDialog();
        }

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            frmAddOrUpdateUser frm = new frmAddOrUpdateUser();
            frm.ShowDialog();
            _LoadAllUsers();
        }

        private void FiredItems_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to disable this user?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (clsUser.StopThisUser((int)dgvAllUsers.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("User has been disabled successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        private void changePassword_Click(object sender, EventArgs e)
        {
            frmChangePassword frm = new frmChangePassword(clsUser.Find((int)dgvAllUsers.CurrentRow.Cells[0].Value), frmChangePassword.EnMode.ByAdmin);
            frm.ShowDialog();
        }

        private void g_Opening(object sender, CancelEventArgs e)
        {
            if (!clsUser.IsAdmin(clsGlobal.current_user.userID))
            {
                changePassword.Enabled = false;
                UserPErmissions.Enabled = false;
                FiredItems.Enabled = false;
                changeUSername.Enabled = false;
            }
        }

        private void changeUSername_Click(object sender, EventArgs e)
        {
            frmChangeUserName frm = new frmChangeUserName(clsUser.Find((int)dgvAllUsers.CurrentRow.Cells[0].Value), frmChangeUserName.EnMode.ByAdmin);
            frm.ShowDialog();
        }
    }
}
