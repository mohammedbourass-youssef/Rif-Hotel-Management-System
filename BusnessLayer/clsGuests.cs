using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BusnessLayer
{
    public class clsGuests
    {
        public int guestsID {  get; set; }
        public clsPerson person {  get; set; }
        public DateTime firstappliedDate { get; set; }
        public clsGuests()
        {
            guestsID = 0;
            person = null;
            firstappliedDate = DateTime.Now;
        }
        clsGuests(int guestsID, clsPerson person ,DateTime firstapplieddate)
        {
            this.guestsID = guestsID;
            this.person = person;
            this.firstappliedDate = firstapplieddate;
        }
        public static clsGuests Find(int personID)
        {
            int guestsID = 0;
            DateTime firstapplieddate = DateTime.MinValue;
            return (clsGuestsDataAccess.Find(personID, ref guestsID, ref firstapplieddate)) ? new clsGuests(guestsID, clsPerson.Find(personID), firstapplieddate) : null;
        }
        public static clsGuests FindByGuest(int guest)
        {
            int personID = 0;
            DateTime firstapplieddate = DateTime.MinValue;
            return (clsGuestsDataAccess.FindByGuestID(guest, ref personID, ref firstapplieddate)) ? new clsGuests(guest, clsPerson.Find(personID), firstapplieddate) : null;
        }
        public bool Save()
        {
            guestsID = clsGuestsDataAccess.Create(person.PersonID);
            return guestsID != 0;
        }
        public static DataTable GetAllGuests()
        {
            return clsGuestsDataAccess.Get();
        }
        public static DataTable GetDataOfTheReservationOfMonth(int month)
        {
            return clsGuestsDataAccess.GetTheAnalyticsOfMonth(month);
        }
        public static double GettotalGuestOfThisMonth(int month)
        {
            return clsGuestsDataAccess.CountTotalGuestMonth(month);
        }
        static public string GetLoyaleGuests()
        {
            return clsGuestsDataAccess.GetLoyaleGuests();
        }
    }
}
