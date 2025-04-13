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
using HotelManagementSystem.Employee;
using SamplePortProject;

namespace HotelManagementSystem.Reservations
{
    public partial class frmExtendForAnotherDate : Form
    {
        clsReservation _reservation;
        public frmExtendForAnotherDate(clsReservation reservation)
        {
            InitializeComponent();
            this._reservation = reservation;
        }

        private void frmExtendForAnotherDate_Load(object sender, EventArgs e)
        {
            CheckInDate.Value = DateTime.Now;
            txtRoomType.Text = clsRooms.GetCategory_By_RoomID(_reservation.RoomID);
            c.DataSource = clsReservation.GetAvailableRoomsOfSpecialCategoryAndDate(clsRoomsCategory.FindByName(txtRoomType.Text), DateTime.Now);
            clsRoomsCategory category = clsRoomsCategory.Find(clsRooms.GetCategory_By_RoomID(clsRooms.GetIDByRoomNumber((string)c.CurrentRow.Cells[0].Value)));
            txtPricePerDay.Text = category.Price.ToString();

        }
        int _payementID = 6;
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
        private void GB_RoomMate_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSa_Click(object sender, EventArgs e)
        {
            if(numPeriod.Value != 0)
            {
                clsReservation reservation = new clsReservation
                {
                    StartDate = CheckInDate.Value,
                    GuestID = _reservation.GuestID,
                    EndDate = CheckInDate.Value.AddDays(Convert.ToInt32(numPeriod.Value)),
                    Status = 1,
                    AppliedDate = DateTime.Now,
                    RoomID = clsRooms.GetIDByRoomNumber(Convert.ToString(c.CurrentRow.Cells[0].Value)),
                    CreatedByUserID = clsGlobal.current_user.userID,
                    ReservationType = 1,
                    GuestmateID = _reservation.GuestmateID,
                    ExtendOfreserID = _reservation.ReservationID,
                    Guest = _reservation.Guest,
                    Guestemate = _reservation.Guestemate
                };
                if (reservation.Save())
                {
                   clsReservation.Check_In(reservation.ReservationID,clsGlobal.current_user.userID,_payementID);
                   clsReservation.Check_Out(_reservation.ReservationID);
                   frmTicketInfo frmTicket = new frmTicketInfo(reservation);
                   frmTicket.LoadAllMemmbers();
                   frmTicket.PrintSecondTicket();
                }
            }
        }

        private void cmRoomType_SelectedIndexChanged(object sender, EventArgs e)
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
                }
                else
                {
                    if (Convert.ToString(c.CurrentRow.Cells[1].Value) == "Unlimited")
                    {
                        lblPeriodMessage.Visible = true;
                        lblPeriodMessage.Text = "Valid period.";
                        lblPeriodMessage.Location = new Point(226, 146);
                        lblPeriodMessage.ForeColor = Color.Green;
                    }
                    else
                    {

                        if (numPeriod.Value > Convert.ToDecimal(c.CurrentRow.Cells[1].Value))
                        {
                            lblPeriodMessage.Visible = true;
                            lblPeriodMessage.Text = "Invalid period. Please select another room or adjust the period.";
                            lblPeriodMessage.Location = new Point(4, 146);
                            lblPeriodMessage.ForeColor = Color.Red;
                        }
                        else
                        {
                            lblPeriodMessage.Visible = true;
                            lblPeriodMessage.Text = "Valid period.";
                            lblPeriodMessage.Location = new Point(226, 146);
                            lblPeriodMessage.ForeColor = Color.Green;
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
            double price = double.Parse(txtPricePerDay.Text);
            price =  Convert.ToDouble(numPeriod.Value) * price;
            txtTotalPrice.Text = price.ToString();
        }

        private void c_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            clsRoomsCategory category = clsRoomsCategory.Find(clsRooms.GetCategory_By_RoomID((int)c.CurrentRow.Cells[0].Value));
            txtPricePerDay.Text = category.Price.ToString();
        }
    }
}
