using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;
using BusnessLayer;
using HotelManagementSystem.Employee;
using HotelManagementSystem.Guests;
using HotelManagementSystem.People;

namespace HotelManagementSystem.Reservations
{
    public partial class frmAddNewReservations : Form
    {
        clsPerson person = null;
        clsPerson mate = null;
        DataTable _AllRooms = null;
        int _payementID = 6;

        //Guests 
        clsGuests _Guests = null;
        clsGuests _MateGuest = null;
        public frmAddNewReservations()
        {
            InitializeComponent();
        }
        public frmAddNewReservations(clsGuests guest)
        {
            InitializeComponent();
            _Guests = guest;
        }
        private void SelectPersonForm_OnPersonSelected(object sender, BusnessLayer.clsPerson e)
        {
            clsGuests guests = clsGuests.Find(e.PersonID);
            if(guests == null)
            {
                person = e;
                showperson.Visible = true;
                lblName.Text = e.GetFullName();
            }
            else
            {
                MessageBox.Show("This Is Already A Guest Please ,Go to :  Manage Guests > Select Guest > add new reservation");
            }
        }
        private void SelectPersonForm_OnGuestMateSelected(object sender, BusnessLayer.clsGuests e)
        {
            if (e != null)
            {
                _MateGuest = e;
                lblMateID.Text =e.guestsID.ToString();
                lblNameMateID.Text = e.person.GetFullName();
            }
            else
            {
                MessageBox.Show("This Is Already A Guest Please ,Go to :  Manage Guests > Select Guest > add new reservation");
            }
        }
        private void SelectPersonForm_OnMateSelected(object sender, BusnessLayer.clsPerson e)
        {
            if (person != null)
            {
                if (person.PersonID == e.PersonID)
                {
                    MessageBox.Show("This person is already selected. Please try again.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    mate = e;
                    showmate.Visible = true;
                    lblNameMateID.Text = e.GetFullName();
                }
            }
            else
            {
                MessageBox.Show("Please select a reservation first.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        private void btnSelect_Click(object sender, EventArgs e)
        {
            frmSelectPerson frm = new frmSelectPerson();
            frm.OnPersonSelected += SelectPersonForm_OnPersonSelected;
            frm.ShowDialog();
        }

        private void showperson_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowPersonDetails frm = new frmShowPersonDetails(person.PersonID);
            frm.ShowDialog();
        }

        private void frmAddNewReservations_Load(object sender, EventArgs e)
        {
            CheckInDate.MinDate = DateTime.Now;
            DataTable data = clsRoomsCategory.GetAll();
            foreach (DataRow row in data.Rows)
            {
                cmRoomType.Items.Add(row[1].ToString());
            }
            cmRoomType.SelectedIndex = 0;
            _AllRooms = clsRooms.Get();
            Cash.Checked = true;
            if(_Guests != null)
            {
               btnSelect.Enabled = false;
               lblGuestID.Text = _Guests.guestsID.ToString();
               lblName.Text = _Guests.person.GetFullName();
            }
        }

        private void pnlBody_Paint(object sender, PaintEventArgs e)
        {

        }
        private void cmRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblDescription.Visible = false;
            if (cmRoomType.SelectedIndex !=0)
            {
                c.DataSource = clsReservation.GetAvailableRoomsOfSpecialCategoryAndDate(cmRoomType.SelectedIndex + 3, CheckInDate.Value);
                _changeThelblPeriod();
                if(cmRoomType.SelectedIndex == 1)
                {
                    GB_RoomMate.Enabled = false;
                }
                else
                {
                    GB_RoomMate.Enabled=true;
                }
            }
            else
            {
                if (c.Rows.Count > 0)
                    c.DataSource = null; 
            }
        }

        void _changeLblTime(DateTime date)
        {
            if (clsReservation.IsThisGuestHasAnActiveReservation(_Guests.guestsID,date ))
            {
                lblCheckinDate.Visible = true;
              
                lblCheckinDate.Text = "This Person Has Already An Reservation In this time.";
                lblCheckinDate.Location = new Point(158, 88);
                lblCheckinDate.ForeColor = Color.Red;
                btnSa.Enabled = false;
            }
            
            else
            {
                lblCheckinDate.Visible = true;

                lblCheckinDate.Text = "Valid";
                lblCheckinDate.Location = new Point(251, 88);
                lblCheckinDate.ForeColor = Color.Green;
                btnSa.Enabled = true;
            }
        }

        private void CheckInDate_ValueChanged(object sender, EventArgs e)
        {
            lblDescription.Visible = false;
            _changeThelblPeriod();
            if (cmRoomType.SelectedIndex != 0)
            {
                c.DataSource = clsReservation.GetAvailableRoomsOfSpecialCategoryAndDate(cmRoomType.SelectedIndex + 3, CheckInDate.Value);
            }
            if(_Guests != null)
            {
                _changeLblTime(CheckInDate.Value);
            }
        }
        string _GetDescription()
        {
            foreach(DataRow row in _AllRooms.Rows)
            {
                if(row[1].ToString() == c.CurrentRow.Cells[0].Value.ToString())
                    return row[5].ToString();
            }
            return "";
        }

        private void dgvAllReservations_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {

            if (c.Rows.Count > 0)
            {
                lblDescription.Visible = true;
                lblDescription.Text = "Description  : " + _GetDescription();              
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        void _changeThelblPeriod()
        {
            if (c.Rows.Count > 0)
            {
                if (numPeriod.Value == 0)
                {
                    lblPeriodMessage.Visible = true;
                    lblPeriodMessage.Text = "Please select a period.";
                    lblPeriodMessage.Location = new Point(226, 146);
                    lblPeriodMessage.ForeColor = Color.Red;
                    btnSa.Enabled = false;
                }
                else
                {
                    if (Convert.ToString(c.CurrentRow.Cells[1].Value) == "Unlimited")
                    {
                        lblPeriodMessage.Visible = true;
                        lblPeriodMessage.Text = "Valid period.";
                        lblPeriodMessage.Location = new Point(226, 146);
                        lblPeriodMessage.ForeColor = Color.Green;
                        btnSa.Enabled = true;
                    }
                    else
                    {

                        if (numPeriod.Value > Convert.ToDecimal(c.CurrentRow.Cells[1].Value))
                        {
                            lblPeriodMessage.Visible = true;
                            lblPeriodMessage.Text = "Invalid period. Please select another room or adjust the period.";
                            lblPeriodMessage.Location = new Point(4, 146);
                            lblPeriodMessage.ForeColor = Color.Red;
                            btnSa.Enabled = false;
                        }
                        else
                        {
                            lblPeriodMessage.Visible = true;
                            lblPeriodMessage.Text = "Valid period.";
                            lblPeriodMessage.Location = new Point(226, 146);
                            lblPeriodMessage.ForeColor = Color.Green;
                            btnSa.Enabled = true;
                        }
                    }
                }
               
            }
            else
            {
                lblPeriodMessage.Visible = false;
            }

        }

        private void numPeriod_ValueChanged(object sender, EventArgs e)
        {
            _changeThelblPeriod();
            if (_Guests != null)
            {
                _changeLblTime(CheckInDate.Value.AddDays(Convert.ToDouble(numPeriod.Value)));
            }
        }

        private void dgvAllReservations_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            _changeThelblPeriod();
            
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            frmSelectPerson frm = new frmSelectPerson();
            frm.OnPersonSelected += SelectPersonForm_OnMateSelected;
            frm.ShowDialog();
        }

        private void showmate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowPersonDetails frm = new frmShowPersonDetails(mate.PersonID);
            frm.ShowDialog();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to cancel adding this new reservation?",
           "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnSa_Click(object sender, EventArgs e)
        {
            if (_Guests != null)
            {
                clsReservation reservation = new clsReservation
                {
                    StartDate = CheckInDate.Value,
                    GuestID = _Guests.person.PersonID,
                    EndDate = CheckInDate.Value.AddDays(Convert.ToInt32(numPeriod.Value)),
                    Status = 1,
                    AppliedDate = DateTime.Now,
                    RoomID = clsRooms.GetIDByRoomNumber(Convert.ToString(c.CurrentRow.Cells[0].Value)),
                    CreatedByUserID = clsGlobal.current_user.userID,
                    ReservationType = 2
                };

                // Ensure the room ID is valid before proceeding
                if (reservation.RoomID == -1)
                {
                    MessageBox.Show("The selected room is not available. Please choose a different room.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Assign GuestmateID only if the room type requires it
                if (cmRoomType.SelectedIndex != 1 && _MateGuest != null)
                {
                    reservation.GuestmateID = _MateGuest.person.PersonID;
                }

                // Attempt to save the reservation
                if (reservation.Save(_payementID))
                {
                    MessageBox.Show("The new reservation has been added successfully!",
                        "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblGuestID.Text = reservation.GuestID.ToString();
                    btnSa.Enabled = false;
                }
                else
                {
                    MessageBox.Show("An error occurred while saving the reservation. Please try again.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                this.Close();
                return;
            }
            if (cmRoomType.SelectedIndex == 0 || numPeriod.Value == 0 || person == null || (cmRoomType.SelectedIndex != 1 && mate == null))
            {
                MessageBox.Show("Please fill in all required fields correctly before proceeding.",
                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(person != null) 
            {
                clsReservation reservation = new clsReservation
                {
                    StartDate = CheckInDate.Value,
                    GuestID = person.PersonID,
                    EndDate = CheckInDate.Value.AddDays(Convert.ToInt32(numPeriod.Value)),
                    Status = 1,
                    AppliedDate = DateTime.Now,
                    RoomID = clsRooms.GetIDByRoomNumber(Convert.ToString(c.CurrentRow.Cells[0].Value)),
                    CreatedByUserID = clsGlobal.current_user.userID,
                    ReservationType = 2
                };

                // Ensure the room ID is valid before proceeding
                if (reservation.RoomID == -1)
                {
                    MessageBox.Show("The selected room is not available. Please choose a different room.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Assign GuestmateID only if the room type requires it
                if (cmRoomType.SelectedIndex != 1 && mate != null)
                {
                    reservation.GuestmateID = mate.PersonID;
                }

                // Attempt to save the reservation
                if (reservation.Save(_payementID))
                {
                    MessageBox.Show("The new reservation has been added successfully!",
                        "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblGuestID.Text = reservation.GuestID.ToString();
                    btnSa.Enabled = false;
                }
                else
                {
                    MessageBox.Show("An error occurred while saving the reservation. Please try again.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
          

        }

        private void guna2GroupBox4_Click(object sender, EventArgs e)
        {

        }
        
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Visa.Checked = true;
        }

        private void Visa_CheckedChanged(object sender, EventArgs e)
        {
            _payementID = 7;
        }

        private void Cash_CheckedChanged(object sender, EventArgs e)
        {
            _payementID = 6;
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            Cash.Checked = true;
        }

        private void MasterCard_CheckedChanged(object sender, EventArgs e)
        {
            _payementID = 8;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            MasterCard.Checked = true;
        }

        private void Paypal_CheckedChanged(object sender, EventArgs e)
        {
            _payementID = 9;
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            Paypal.Checked = true;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void showperson_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowPersonDetails details    = new frmShowPersonDetails(person.PersonID);
            details.ShowDialog();
        }

        private void showmate_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowPersonDetails details = new frmShowPersonDetails(mate.PersonID);
            details.ShowDialog();
        }

        private void btnGuest_Click(object sender, EventArgs e)
        {
            frmManageGuests frm = new frmManageGuests(true);
            frm.OnPersonSelected += SelectPersonForm_OnGuestMateSelected;
            frm.ShowDialog();
        }
    }
}
