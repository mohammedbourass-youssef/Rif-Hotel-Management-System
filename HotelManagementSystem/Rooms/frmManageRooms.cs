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
using HotelManagementSystem.Guests;

namespace HotelManagementSystem.Rooms
{
    public partial class frmManageRooms : Form
    {
        enum EnFilter {
            None,RoomID,RoomNumber,RoomStatus,Category
        }
        EnFilter _filter = EnFilter.None;
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
        public frmManageRooms()
        {
            InitializeComponent();
        }
        void _Load()
        {
            dgvAllRooms.DataSource = clsRooms.Get();
        }

        private void frmManageRooms_Load(object sender, EventArgs e)
        {
            _Load();
            cmFilter.SelectedIndex = 0;
            DataTable data = clsRoomsCategory.GetAll();
            foreach (DataRow row in data.Rows)
            {
                cmCategory.Items.Add(row[1].ToString());
            }
            cmCategory.SelectedIndex = 0;
            cmRoomStatus.SelectedIndex = 0;

        }

        private void cmFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            _Load();
            switch(cmFilter.SelectedIndex)
            {
                
                case 0: _filter = EnFilter.None;
                    cmCategory.Visible = false;
                    cmRoomStatus.Visible = false;
                    txtSearch.Visible = false;
                    break;
                case 1:
                    _filter = EnFilter.RoomID;
                    cmCategory.Visible = false;
                    cmRoomStatus.Visible = false;
                    txtSearch.Visible = true;
                    break;
                case 2:
                    _filter = EnFilter.RoomNumber;
                    cmCategory.Visible = false;
                    cmRoomStatus.Visible = false;
                    txtSearch.Visible = true;
                    break;
                case 3:
                    _filter = EnFilter.RoomStatus;
                    cmCategory.Visible = false;
                    cmRoomStatus.Visible = true;
                    txtSearch.Visible = false;
                    break;
                case 4: 
                      _filter = EnFilter.Category;
                    cmCategory.Visible = true;
                    cmRoomStatus.Visible = false;
                    txtSearch.Visible = false;
                    break;

            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataTable table = clsRooms.Get();
            if (!string.IsNullOrEmpty(txtSearch.Text))
            {
                if(_filter != EnFilter.RoomID)
                {
                    DataView view = table.DefaultView;
                    view.RowFilter = "[" + cmFilter.Text + "] LIKE '" + txtSearch.Text + "%'";
                    dgvAllRooms.DataSource = view;
                }
                else
                {
                    DataView view = table.DefaultView;
                    view.RowFilter = "[" + cmFilter.Text + "] = '" + txtSearch.Text + "'";
                    dgvAllRooms.DataSource = view;
                }
            }
            else
            {
                _Load();
            }
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Block the input
            }
        }

        private void cmRoomStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable table = clsRooms.Get();
            if (cmRoomStatus.SelectedIndex != 0)
            {
                if (_filter == EnFilter.RoomStatus)
                {
                    DataView view = table.DefaultView;
                    view.RowFilter = "["  +cmFilter.Text + "] = '" + cmRoomStatus.Text + "'";
                    dgvAllRooms.DataSource = view;
                }
            }
            else
            { _Load(); }
        }
        private void cmCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable table = clsRooms.Get();
            if (cmCategory.SelectedIndex != 0)
            {
                if (_filter == EnFilter.Category)
                {
                    DataView view = table.DefaultView;
                    view.RowFilter = "[" + cmFilter.Text + "] = '" + cmCategory.Text + "'";
                    dgvAllRooms.DataSource = view;
                }
            }
            else
            { _Load(); }
        }

        private void g_Opening(object sender, CancelEventArgs e)
        {
           
            if ((string)dgvAllRooms.CurrentRow.Cells[2].Value == "Available")
            {
                SetAvailable.Enabled = false;
                maintenance.Enabled = true;
            }
            else if((string)dgvAllRooms.CurrentRow.Cells[2].Value == "Occupied")
            {
                SetAvailable.Enabled = false;
                maintenance.Enabled = false;
            }
            else
            {
                SetAvailable.Enabled = true;
                maintenance.Enabled = false;
            }
        }

        private void maintenance_Click(object sender, EventArgs e)
        {
            if (clsRooms.SetForMantence((string)dgvAllRooms.CurrentRow.Cells[1].Value))
            {
                MessageBox.Show("Set for mantenance Succefully");
            }
            else
            {
                MessageBox.Show("ERROR-404 . . . !!");
            }
            _Load();
        }

        private void occupants_Click(object sender, EventArgs e)
        {
            DataTable data = clsRooms.GetAllRoomOcuppent((string)dgvAllRooms.CurrentRow.Cells[1].Value);
            if(data != null)
            {
                frmManageGuests frm = new frmManageGuests((string)dgvAllRooms.CurrentRow.Cells[1].Value);
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("There is no occupant of this room , at this time ... ERROR-404");
            }
        }

        private void SetAvailable_Click(object sender, EventArgs e)
        {
            if (clsRooms.SetForAvailable((string)dgvAllRooms.CurrentRow.Cells[1].Value))
            {
                MessageBox.Show("New Status Set Succufuly");
            }
            else
            {
                MessageBox.Show("ERROR-404 . . . !!");
            }
            _Load();
        }
    }
}
