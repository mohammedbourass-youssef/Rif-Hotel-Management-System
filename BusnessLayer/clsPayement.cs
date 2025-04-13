using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BusnessLayer
{
    public class clsPayement
    {
        public int PayementID { get; set; }
        public decimal Amount { get; set; }
        public int ReservationID { get; set; }
        public DateTime Date { get; set; }
        public int PayementMethodID { get; set; }
        public int CreatedByUserID { get; set; }
        public string Description { get; set; }
        clsPayement(int payementID, decimal amount, int reservationID, DateTime date, int payementMethodID, int createdByUserID, string description)
        {
            PayementID = payementID;
            Amount = amount;
            ReservationID = reservationID;
            Date = date;
            PayementMethodID = payementMethodID;
            CreatedByUserID = createdByUserID;
            Description = description;
        }

        public static clsPayement Find(int reservationID)
        {
            int PayementID = 0;
            decimal Amount = 0.0m;
            DateTime Date = DateTime.MinValue;
            int PayementMethodID = 0;
            int CreatedByUserID = 0;
            string Description = string.Empty;

            return (clsPayementDataAccess.FindBookingPrice(reservationID, ref Amount, ref PayementID, ref Date, ref PayementMethodID, ref CreatedByUserID, ref Description)) ?
                new clsPayement(PayementID, Amount, reservationID, Date, PayementMethodID, CreatedByUserID, Description) : null;

        }
        public static clsPayement FindTotal(int reservationID)
        {
            int PayementID = 0;
            decimal Amount = 0.0m;
            DateTime Date = DateTime.MinValue;
            int PayementMethodID = 0;
            int CreatedByUserID = 0;
            string Description = string.Empty;

            return (clsPayementDataAccess.FindTotalPrice(reservationID, ref Amount, ref PayementID, ref Date, ref PayementMethodID, ref CreatedByUserID, ref Description)) ?
                new clsPayement(PayementID, Amount, reservationID, Date, PayementMethodID, CreatedByUserID, Description) : null;

        }
        static public DataTable GetAnalyticsOfThisAllMonths(int month)
        {
            return clsPayementDataAccess.GetAnalyticsOfThisAllMonths(month);
        }
        static public DataTable GetAnalyticsOfThisAllYear(int yaer)
        {
            return clsPayementDataAccess.GetAnalyticsOfThisAllYear(yaer);
        }
        static public double CountTotalIncomeOf(int month)
        {
            return clsPayementDataAccess.CountOdTotalIncomOfMonth(month);
        }
        static public double CountTotalIncomeOfYear(int year)
        {
            return clsPayementDataAccess.CountOdTotalIncomOfYear(year);
        }
        static public DataTable GetTheAnalyticsOfPayementMethod()
        {
            return clsPayementDataAccess.GetTheAnalyticsOfPayementMethod();
        }
        static public string GetTheMostUsedMethodOfPayement()
        {
            return clsPayementDataAccess.GetTheMostUsedMethodOfPayement();
        }
        static public DataTable GetTheAnalyticsOfRoomsCategory()
        {
            return clsPayementDataAccess.GetTheAnalyticsOfRoomsCategory();
        }
        static public string GetTheMostUsedRoomCategories()
        {
            return clsPayementDataAccess.GetTheMostUsedRoomCategories();
        }
        static public string GetTheMostCountry()
        {
            return clsPayementDataAccess.GetTheMostCountry();
        }
        static public double CountOdTotalIncomOfDaySpecial(DateTime time)
        {
            return clsPayementDataAccess.CountOdTotalIncomOfDaySpecial(time);
        }
        static public DataTable GetTheAnalyticsOfCancelDay(DateTime month)
        {
            return clsPayementDataAccess.GetTheAnalyticsOfCancelDay(month);
        }
        static public double CountCanceldReservation(int month)
        {
            return clsPayementDataAccess.CountCanceldReservation(month);
        }
        static public DataTable GetPagingAllPayement(int page)
        {
            return clsPayementDataAccess.GetPagingAllPayement(page);
        }
        static public int CountTotalPayement()
        {
            return clsPayementDataAccess.CountTotalPayement();
        }
    }
}
