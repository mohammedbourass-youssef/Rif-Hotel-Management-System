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

namespace HotelManagementSystem.Reservations
{
    public partial class ctrlReservationDetails : UserControl
    {
        public ctrlReservationDetails()
        {
            InitializeComponent();
        }
        void _SetPictureMethod(int PayementMethodID)
        {
            cash.Visible = false;
            mastercard.Visible = false;
            paypal.Visible = false;
            Visa.Visible = false;
            if(PayementMethodID == 6) 
                cash.Visible = true;
            else if(PayementMethodID == 7)
                Visa.Visible=true;
            else if (PayementMethodID == 8)
                mastercard.Visible = true;
            else if (PayementMethodID == 9)
                paypal.Visible=true;
        }
        public void SetDataToShow(clsReservation reservation)
        {
            lblReID.Text = reservation.ReservationID.ToString();
            lblName.Text = reservation.Guest.person.GetFullName();
            clsUser user = clsUser.Find(reservation.CreatedByUserID);
            user.Employee = clsEmployee.Find(user.EmployeeID);
            lblUserID.Text = user.Employee.person.GetFullName();
            lblDate.Text = reservation.AppliedDate.ToString("D");
            lblRoomNumber.Text = clsRooms.GetRoomNumberByID(reservation.RoomID);
            lblType.Text = clsRooms.GetCategory_By_RoomID(reservation.RoomID);
            lblStartDate.Text = reservation.StartDate.ToString("D");
            lblEndDate.Text = reservation.EndDate.ToString("D");
            clsPayement x = clsPayement.Find(reservation.ReservationID);
            if(x != null)
            {
                lblBooking.Text = x.Amount.ToString();
                _SetPictureMethod(x.PayementMethodID);
            }
            else
            {
                lblBooking.Text = "Extending Reservation , Is free for booking";
            }
        }

        private void Visa_Click(object sender, EventArgs e)
        {

        }
    }
}
