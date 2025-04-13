using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BusnessLayer
{
    
    public enum EnPermissions { AllPermissions = -1, ManageGuets = 1, ManageUsers = 2, ManagePayement = 4,ManageReservations = 8 ,ManagePeople = 16,ManageEmployee =32,ManageRooms = 64 ,ManageOrders= 128 }
    enum EnMode { Update , Addnew}
    public class clsUser
    {
        //For Permissions Tratement 
        public bool HavePermissionOf(EnPermissions enPermissions)
        {
            if (Convert.ToInt32(EnPermissions.AllPermissions) == permissions)
                return true;
            else if ((Convert.ToInt32(enPermissions) & permissions) == Convert.ToInt32(enPermissions))
                return true;
            else
                return false;
        }
        //The CLass other method and proprities 
        EnMode mode;
        public int userID {  get; set; }
        public clsEmployee Employee {  get; set; }
        public  string username { get; set; }
        public  string password { get; set; }
        public int permissions { get; set; }
        public int EmployeeID { get; set; }
        public  clsUser CreatedByuser { get; set; }
        public bool IsActive { get; set; }
        public clsUser()
        {
            userID = 0;
            Employee = null;
            username = null; 
            password = null;
            permissions = 0;
            CreatedByuser = null;
            mode = EnMode.Addnew;
        }

        clsUser( int userID, int employeeID, int permissions , string username,string password,int? createdbyuserID , bool IsActive)
        {
            mode = EnMode.Update;
            this.userID = userID;
            EmployeeID = employeeID;
            this.permissions = permissions;
            this.username = username;
            this.password = password;
            this.CreatedByuser = (createdbyuserID != null)? clsUser.Find(Convert.ToInt32(createdbyuserID)):null;
            this.IsActive = IsActive;
        }
         
        public static clsUser Find(string username){
            int userID = 0; 
            int employeeID = 0;
            string password = ""; 
            int permissions = 0;
            int? createduserID = null;
            bool IsActive = false;
            if (clsUsersDataAccess.Find(username, ref userID, ref employeeID, ref password, ref createduserID, ref permissions,ref IsActive))
            {
                return new clsUser(userID, employeeID, permissions, username, password, createduserID, IsActive);
            }
            else
                return null; 
        }
        public static bool IsExist(string username)
        {
            return clsUsersDataAccess.IsExist(username);
        }
        public static bool IsAdmin(int userID)
        {
            return clsEmployeeDataAccess.IsAdmin(userID);
        }
        public static clsUser Find(int userID)
        {
            string username = string.Empty;
            int employeeID = 0;
            string password = "";
            int permissions = 0;
            int? createduserID = null;
            bool IsActive = false;
            if (clsUsersDataAccess.Find(userID, ref username, ref employeeID, ref password, ref createduserID, ref permissions,ref IsActive))
            {
                return new clsUser(userID, employeeID, permissions, username, password, createduserID, IsActive);
            }
            else
                return null;
        }
        public static DataTable GetAllUser()
        {
            return clsUsersDataAccess.Get();
        }

        public bool Save()
        {
            userID =  clsUsersDataAccess.Create(EmployeeID,username,password,CreatedByuser.userID,permissions);
            return userID > 0;
        }
        public bool StopThisUser()
        {
            if (clsUsersDataAccess.Update(userID, username, password, CreatedByuser.userID, permissions, false))
            {
                IsActive = false;
                return true;
            }
            return false;
        }
        static public bool StopThisUser(int ID)
        {
            return Find(ID).StopThisUser();
        }
        public bool ChangeThePermissions(int Newpermissions)
        {
            if (clsUsersDataAccess.Update(userID, username, password, 0, Newpermissions, IsActive))
            {
                permissions = Newpermissions;
                return true;
            }
            return false;
        }
        public bool ChangePassword(string Newpassword)
        {
            if( clsUsersDataAccess.Update(userID, username, Newpassword,0, permissions, IsActive))
            {
                password = Newpassword;
                return true;
            }
            return false;
        }
        public bool ChangeUserName(string newusername)
        {
            if (clsUsersDataAccess.Update(userID, newusername, password, 0, permissions, IsActive))
            {
                username = newusername;
                return true;
            }
            return false;
        }

        public static bool IsExist(int userID)
        {
            return clsUsersDataAccess.IsExist(userID);
        }
        public static int CountNumberOfUser()
        {
            return clsUsersDataAccess.CountNumberOfUser();
        } 
        public static int CountCountGuestsWeHave()
        {
            return clsUsersDataAccess.CountCountGuestsWeHave();
        }
    }
}
