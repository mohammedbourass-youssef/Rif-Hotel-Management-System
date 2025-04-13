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
using HotelManagementSystem.Classes;
using HotelManagementSystem.People;
using SamplePortProject;

namespace HotelManagementSystem.Reservations
{
    public partial class frmReservations : Form
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
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            SetRoundedRegion(30); // Call function to make the form rounded
        }
        enum EnFilter {
            None,ReservationID,Room,FullName,ResStatus,ResType
        }
        EnFilter _filter = EnFilter.None;
        public frmReservations()
        {
            InitializeComponent();
        }
        void _Load()
        {
            dgvAllReservations.DataSource = clsReservation.GetAll();
            cmFilter.SelectedIndex = 0;
            cmResStatus.SelectedIndex = 0;
            cmType.SelectedIndex = 0;
        }
        private void frmReservations_Load(object sender, EventArgs e)
        {
            _Load();
            cmType.SelectedIndex = 0;
            cmResStatus.SelectedIndex = 1;
            cmFilter.SelectedIndex = 4;
            _filter = EnFilter.ResStatus;
            cmResStatus_SelectedIndexChanged(cmResStatus, e);
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable table = clsReservation.GetAll();
            if (cmType.SelectedIndex != 0)
            {
                if (_filter == EnFilter.ResType)
                {
                    DataView view = table.DefaultView;
                    view.RowFilter = "[" + cmFilter.Text + "] = '" + cmType.Text + "'";
                    dgvAllReservations.DataSource = view;
                }
            }
            else
            { _Load(); }
        }

        private void cmResStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable table = clsReservation.GetAll();
            if (cmResStatus.SelectedIndex != 0)
            {
                if (_filter == EnFilter.ResStatus)
                {
                    DataView view = table.DefaultView;
                    view.RowFilter = "[" + cmFilter.Text + "] = '" + cmResStatus.Text + "'";
                    dgvAllReservations.DataSource = view;
                }
            }
            else
            { _Load(); }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataTable table = clsReservation.GetAll();
            if (!string.IsNullOrEmpty(txtSearch.Text))
            {
                if (_filter != EnFilter.ReservationID)
                {
                    DataView view = table.DefaultView;
                    view.RowFilter = "[" + cmFilter.Text + "] LIKE '" + txtSearch.Text + "%'";
                    dgvAllReservations.DataSource = view;
                }
                else
                {
                    DataView view = table.DefaultView;
                    view.RowFilter = "[" + cmFilter.Text + "] = '" + txtSearch.Text + "'";
                    dgvAllReservations.DataSource = view;
                }
            }
            else
            {
                _Load();
            }
        }

        private void cmFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            switch (cmFilter.SelectedIndex)
            {
                case 0: _filter = EnFilter.None;
                    cmResStatus.Visible = false;
                    cmType.Visible = false;
                    txtSearch.Visible = false;
                    _Load();
                    break;
                case 1:
                    _filter = EnFilter.ReservationID;
                    cmResStatus.Visible = false;
                    cmType.Visible = false;
                    txtSearch.Visible = true;
                    break;
                case 2:
                    _filter = EnFilter.Room;
                    cmResStatus.Visible = false;
                    cmType.Visible = false;
                    txtSearch.Visible = true;
                    break;
                case 3:
                    _filter = EnFilter.FullName;
                    cmResStatus.Visible = false;
                    cmType.Visible = false;
                    txtSearch.Visible = true;
                    break;
                case 4:
                    _filter = EnFilter.ResStatus;
                    cmResStatus.Visible = true;
                    cmType.Visible = false;
                    txtSearch.Visible = false;
                    break;
                case 5:
                    _filter = EnFilter.ResType;
                    cmResStatus.Visible = false;
                    cmType.Visible = true;
                    txtSearch.Visible = false;
                    break;
            }
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (_filter != EnFilter.FullName)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true; // Block the input
                }
            }
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            frmAddNewReservations frm = new frmAddNewReservations();
            frm.ShowDialog();
            _Load();
        }

        private void GuestInfo_Click(object sender, EventArgs e)
        {
            clsReservation reservation = clsReservation.Find((int)dgvAllReservations.CurrentRow.Cells[0].Value);
            frmShowPersonDetails frm = new frmShowPersonDetails(reservation.Guest.person.PersonID);
            frm.ShowDialog();
        }

        private void g_Opening(object sender, CancelEventArgs e)
        {
            if (!clsReservation.CanCancel((int)dgvAllReservations.CurrentRow.Cells[0].Value))
            {
                Cancel.Enabled = false;
            }
            else
            {
                Cancel.Enabled = true;
            }
            if (!clsReservation.CanCheckIn((int)dgvAllReservations.CurrentRow.Cells[0].Value))
            {
                check_in.Enabled = false;
            }
            else
            {
                check_in.Enabled = true;
            }

            if (!clsReservation.CanCheckOut((int)dgvAllReservations.CurrentRow.Cells[0].Value))
            {
                Check_out.Enabled = false;
              
            }
            else
            {
                Check_out.Enabled = true;
               
            }
            if (!Check_out.Enabled || ((DateTime)dgvAllReservations.CurrentRow.Cells[6].Value).Date != DateTime.Now.Date)
                Extend.Enabled = false;
            else
                Extend.Enabled = true;

            if ((string)dgvAllReservations.CurrentRow.Cells[8].Value == "New" || (string)dgvAllReservations.CurrentRow.Cells[8].Value == "Cancel")
            {
                Ticket.Enabled = false;
            }
            else
            {
                Ticket.Enabled = true;
            }
            clsReservation reservation = clsReservation.Find((int)dgvAllReservations.CurrentRow.Cells[0].Value);
            clsRoomsCategory category = clsRoomsCategory.Find(clsRooms.GetCategory_By_RoomID(reservation.RoomID));
            if(category.ID == 4)
                roommateinfo.Enabled = false;
            else 
                roommateinfo.Enabled=true;

        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to cancel this reservation?", "Attention", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                if (clsReservation.CancelReservation((int)dgvAllReservations.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("Reservation canceled successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            _Load();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            frmReservationDetatils frm = new frmReservationDetatils(clsReservation.Find((int)dgvAllReservations.CurrentRow.Cells[0].Value));
            frm.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmTicketInfo frm = new frmTicketInfo(clsReservation.Find((int)dgvAllReservations.CurrentRow.Cells[0].Value));
            frm.ShowDialog();
        }
        private void OnSave(object obj,int payementID)
        {
            clsReservation.Check_In((int)dgvAllReservations.CurrentRow.Cells[0].Value, clsGlobal.current_user.userID, payementID);
            MessageBox.Show("Reservation Comlited succefully");
            notifyIcon1.ShowBalloonTip(1000,"New File Dowloaded","Click To Dowload",ToolTipIcon.Info);
            clsReservation reservation = clsReservation.Find((int)dgvAllReservations.CurrentRow.Cells[0].Value);
            clsGlobal.current_user.Employee = clsEmployee.Find(clsGlobal.current_user.EmployeeID);
            clsOtils.GenerateHotelReservationPdf(clsGlobal.DowloadPath + " Ticket_of_reservation__" + reservation.GuestID.ToString() + ".pdf", reservation.Guest.person.GetFullName(), clsGlobal.current_user.Employee.person.GetFullName(),
              DateTime.Now.ToString("D"), "Welcome", "HTL123456789");
        }

        private void check_in_Click(object sender, EventArgs e)
        {
            frmCheckInAndSelectPAyementMEthod frmCheckInAndSelectPAyementMEthod = new frmCheckInAndSelectPAyementMEthod((string)dgvAllReservations.CurrentRow.Cells[3].Value,
                                                                                                                        (DateTime)dgvAllReservations.CurrentRow.Cells[5].Value,
                                                                                                                       (DateTime)dgvAllReservations.CurrentRow.Cells[6].Value);
            frmCheckInAndSelectPAyementMEthod.OnSaveClicked += OnSave;
            frmCheckInAndSelectPAyementMEthod.ShowDialog();
            _Load();
        }

        private void notifyIcon1_Click(object sender, EventArgs e)
        {
            
            
        }

        private void Check_out_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to  Checkout?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                clsReservation.Check_Out((int)dgvAllReservations.CurrentRow.Cells[0].Value);
                frmTicketInfo frm = new frmTicketInfo(clsReservation.Find((int)dgvAllReservations.CurrentRow.Cells[0].Value));
                frm.LoadAllMemmbers();
                frm.PrintSecondTicket();
                _Load();
            }
        }

        private void roommateinfo_Click(object sender, EventArgs e)
        {
            clsReservation reservation = clsReservation.Find((int)dgvAllReservations.CurrentRow.Cells[0].Value);
            if (reservation.Guestemate == null)
                MessageBox.Show("No guest mate found.");
            else
            {
                frmShowPersonDetails frm = new frmShowPersonDetails(reservation.Guestemate.person.PersonID);
                frm.ShowDialog();
            }


        }

        private void Extend_Click(object sender, EventArgs e)
        {
            frmExtendForAnotherDate frm = new frmExtendForAnotherDate(clsReservation.Find((int)dgvAllReservations.CurrentRow.Cells[0].Value));
            frm.ShowDialog();
        }
    }
}
