using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BusnessLayer
{
    public class clsReservation
    {
        public int ReservationID { get; set; }
        public int RoomID { get; set; }
        public clsRooms room { get; set; }
        public int GuestID { get; set; }
        public clsGuests Guest { get; set; }
        public int? GuestmateID { get; set; }
        public clsGuests Guestemate { get; set; }
        public int CreatedByUserID { get; set; }
        public DateTime AppliedDate { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int ReservationType { get; set; }
        public int Status { get; set; }

        public int? ExtendOfreserID {  get; set; }
        public int? ExtendRoomID { get; set; }
        public clsReservation()
        {

        }
        clsReservation(int reservationID, int roomID, int guestID, int? guestmateID, int createdByUserID, DateTime appliedDate, DateTime startDate, DateTime endDate, int reservationType, int status, int? extendRoomID)
        {
            ReservationID = reservationID;
            RoomID = roomID;
            GuestID = guestID;
            Guest =  clsGuests.FindByGuest(guestID);
            GuestmateID = guestmateID;
            if (GuestmateID.HasValue)
                Guestemate = clsGuests.FindByGuest(GuestmateID.Value);
            else
                Guestemate = null;
            CreatedByUserID = createdByUserID;
            AppliedDate = appliedDate;
            StartDate = startDate;
            EndDate = endDate;
            ReservationType = reservationType;
            Status = status;
            ExtendRoomID = extendRoomID;
            
        }

        public static DataTable GetAll()
        {
            return clsReservationsDataAccess.Get();
        }
        public static clsReservation Find(int id)
        {
            int RoomID = 0;
            int GuestID = 0;
            int? GuestmateID = null;
            int CreatedByUserID = 0;
            DateTime AppliedDate = DateTime.MinValue;
            DateTime StartDate = DateTime.MinValue;
            DateTime EndDate = DateTime.MinValue;
            int ReservationType = 0;
            int Status = 0;
            int? ExtendRoomID = null;
            return clsReservationsDataAccess.Find(id, ref RoomID, ref GuestID, ref GuestmateID, ref CreatedByUserID, ref AppliedDate, ref StartDate, ref EndDate, ref ReservationType,
                ref Status, ref ExtendRoomID) ? new clsReservation(id, RoomID, GuestID, GuestmateID, CreatedByUserID, AppliedDate, StartDate, EndDate, ReservationType, Status, ExtendRoomID) : null;
        }
        public static DataTable GetAvailableRoomsOfSpecialCategoryAndDate(int categoryID ,DateTime date)
        {
            return clsReservationsDataAccess.GetAvailableForDateAndCategory(date,categoryID);
        }
        public bool Save(int payementID)
        {
            ReservationID = clsReservationsDataAccess.AddNewReservation(RoomID, GuestID, GuestmateID, CreatedByUserID, AppliedDate, StartDate, EndDate, ReservationType, Status,null, payementID);
            Guest = clsGuests.Find(GuestID);
            GuestID = Guest.guestsID;
            if (GuestmateID.HasValue)
            {
                Guestemate = clsGuests.Find(Convert.ToInt32(GuestmateID));
                GuestmateID = Guest.guestsID;
            }
            return ReservationType > 0;
        }
        public bool Save()
        {
            ReservationID = clsReservationsDataAccess.ExtendReservation(RoomID, GuestID, GuestmateID, CreatedByUserID, AppliedDate, StartDate, EndDate, ReservationType, Status, ExtendOfreserID);

            return ReservationType > 0;
        }
        public static bool CanCancel(int reservationID)
        {
            return clsReservationsDataAccess.CanCancel(reservationID);
        }
        public static bool CanCheckOut(int reservationID)
        {
            return clsReservationsDataAccess.CanCheckOut(reservationID);
        }
        public static bool IsThisGuestHasAnActiveReservation(int guest,DateTime date)
        {
            return clsReservationsDataAccess.IsThisGuestHasAnActiveReservation(guest , date);
        }
        public static int TodaysCheckOut()
        {
            return clsReservationsDataAccess.TodaysCheckOut();
        }
        public static int TodaysCheckIn()
        {
            return clsReservationsDataAccess.TodaysCheckIn();
        }
        public static bool CanCheckIn(int reservationID)
        {
            return clsReservationsDataAccess.CanCheckIN(reservationID);
        }

        public static int Check_In(int reservationID,int userID,int PayementID)
        {
            return clsReservationsDataAccess.Check_In(reservationID, userID, PayementID);
        }
        public static int Check_Out(int reservationID)
        {
            return clsReservationsDataAccess.Check_Out(reservationID);
        }
        public static bool CancelReservation(int reservationID)
        {
            return clsReservationsDataAccess.Cancel(reservationID);
        }
        /// <summary>
        /// This Function Cancel All Non Complited reservation
        /// </summary>
        /// <returns></returns>
        public static bool CancelNonCheckInReservations()
        {
            return clsReservationsDataAccess.CancelNonCheckInReservations();
        }

        
    }
}
