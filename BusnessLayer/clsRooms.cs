using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BusnessLayer
{
    public class clsRooms
    {
        static public DataTable Get()
        {
            return clsRoomsDataAccess_.Get();
        }
        public static int CountAvailableRooms()
        {
            return clsRoomsDataAccess_.CountNumberOfAvailbeRooms();
        }
        public static int GetIDByRoomNumber(string roomNumber)
        {
            int id = 0;
            return (clsRoomsDataAccess_.Find(roomNumber, ref id)) ? id : -1;
        }
        public static bool SetForMantence(string roomnumber)
        {
            return clsRoomsDataAccess_.SetForMantence(roomnumber);
        }
        public static bool SetForAvailable(string roomnumber)
        {
            return clsRoomsDataAccess_.SetForAvailable(roomnumber);
        }
        public static string GetRoomNumberByID(int id)
        { 
            string roomNumber = string.Empty;
            return (clsRoomsDataAccess_.Find(id, ref roomNumber )) ? roomNumber : string.Empty;
        }
        static public DataTable GetAllRoomOcuppent(string roomnumber)
        {
            return clsRoomsDataAccess_.GetAllRoomOcuppent(roomnumber);
        }
        public static string GetCategory_By_RoomID(int id)
        { 
            string roomNumber = string.Empty;
            return (clsRoomsDataAccess_.GetCategory_By_RoomID(id, ref roomNumber )) ? roomNumber : string.Empty;
        }

    }
}
