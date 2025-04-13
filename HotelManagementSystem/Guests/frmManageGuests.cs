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
using HotelManagementSystem.People;
using HotelManagementSystem.Reservations;

namespace HotelManagementSystem.Guests
{
    public partial class frmManageGuests : Form
    {
        public event EventHandler<clsGuests> OnPersonSelected;
        public frmManageGuests()
        {
            InitializeComponent();
        }
        bool _IsDialog;
        public frmManageGuests(bool IsDialog)
        {
            InitializeComponent();
            _IsDialog = IsDialog;
        }
        // if this form , want to show the occupants of special room 
       string _table_to_show_only_occupant = null ;
        public frmManageGuests( string roomnumber)
        {
            InitializeComponent();
            _table_to_show_only_occupant =roomnumber;
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
        enum EnFilter
        {
            None,GuestID,Full_Name,Country
        }
        EnFilter _filter = EnFilter.None;
        void _Load()
        {
            if (_table_to_show_only_occupant != null)
            {
                //mean that the sender is Want only ocuupant of special 
                dgvAllGuests.DataSource = clsRooms.GetAllRoomOcuppent(_table_to_show_only_occupant);
            }
            else
            {
                dgvAllGuests.DataSource = clsGuests.GetAllGuests();
            }
        }
        private void frmManageGuests_Load(object sender, EventArgs e)
        {
            if (_IsDialog)
            {
                btnCancel.Visible = true;
                btnSave.Visible = true;
                btnAdd.Visible = false;
                btnSave.Location = btnSave.Location;
            }
            else
            {
                dgvAllGuests.ContextMenuStrip = g;
            }
            DataTable dt = null;
            if (_table_to_show_only_occupant != null)
            {
                //mean that the sender is Want only ocuupant of special 
                dgvAllGuests.DataSource = clsRooms.GetAllRoomOcuppent(_table_to_show_only_occupant);
                btnCancel.Visible = true;
                btnAdd.Visible = false;
                dt = clsRooms.GetAllRoomOcuppent(_table_to_show_only_occupant);
                BackColor = Color.WhiteSmoke;

                foreach (DataRow dr in dt.Rows)
                {
                    cmCountries.Items.Add(dr[2].ToString());
                }
                dgvAllGuests.ContextMenuStrip = null;
            }
            else
            {
                dgvAllGuests.DataSource = clsGuests.GetAllGuests();
                dt = clsGuests.GetAllGuests();

                foreach (DataRow dr in dt.Rows)
                {
                    cmCountries.Items.Add(dr[3].ToString());
                }
            }
            cmFilter.SelectedIndex = 0;
          
            cmCountries.SelectedIndex = 0;
           
        }

        private void cmFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(cmFilter.SelectedIndex)
            {
                case 0: _filter = EnFilter.None;
                    cmCountries.Visible = false;
                    txtSearch.Visible = false;
                    break;
                case 1: _filter = EnFilter.GuestID;
                    cmCountries.Visible = false;
                    txtSearch.Visible = true;
                    break;
                case 2:_filter = EnFilter.Full_Name;
                    cmCountries.Visible = false;
                    txtSearch.Visible = true;
                    break;
                case 3: _filter = EnFilter.Country;
                    cmCountries.Visible = true;
                    txtSearch.Visible = false;
                    break;
            }
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
           if(_filter == EnFilter.GuestID)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true; // Block the input
                }
            }
        }

        private void cmCountries_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable table = null;
            if (_table_to_show_only_occupant != null)
            {
                //mean that the sender is Want only ocuupant of special 
                table = clsRooms.GetAllRoomOcuppent(_table_to_show_only_occupant);
            }
            else
            {
                table = clsGuests.GetAllGuests();
            }
            if (cmCountries.SelectedIndex != 0)
            {
                if (_filter == EnFilter.Country)
                {
                    DataView view = table.DefaultView;
                    view.RowFilter = "[" + cmFilter.Text + "] = '" + cmCountries.Text + "'";
                    dgvAllGuests.DataSource = view;
                }
            }
            else
            { _Load(); }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataTable table = null;
            if (_table_to_show_only_occupant != null)
            {
                //mean that the sender is Want only ocuupant of special 
                 table = clsRooms.GetAllRoomOcuppent(_table_to_show_only_occupant);
            }
            else
            {
                 table = clsGuests.GetAllGuests();
            }
            if (!string.IsNullOrEmpty(txtSearch.Text))
            {
                if (_filter != EnFilter.GuestID)
                {
                    DataView view = table.DefaultView;
                    view.RowFilter = "[" + cmFilter.Text + "] LIKE '" + txtSearch.Text + "%'";
                    dgvAllGuests.DataSource = view;
                }
                else
                {
                    DataView view = table.DefaultView;
                    view.RowFilter = "[" + cmFilter.Text + "] = '" + txtSearch.Text + "'";
                    dgvAllGuests.DataSource = view;
                }
            }
            else
            {
                _Load();
            }
        }

        private void GuestInfo_Click(object sender, EventArgs e)
        {
            clsGuests guest = clsGuests.FindByGuest((int)dgvAllGuests.CurrentRow.Cells[0].Value);
            frmShowPersonDetails frm = new frmShowPersonDetails(guest.person.PersonID);
            frm.ShowDialog();
        }

        private void ADD_New_Reservation_Click(object sender, EventArgs e)
        {
            clsGuests guest = clsGuests.FindByGuest((int)dgvAllGuests.CurrentRow.Cells[0].Value);
            frmAddNewReservations frm = new frmAddNewReservations(guest);
            frm.ShowDialog();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to continue??","Attention",MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
               this.OnPersonSelected?.Invoke(this,clsGuests.FindByGuest((int)dgvAllGuests.CurrentRow.Cells[0].Value));
                this.Close();
            }
        }
    }
}
