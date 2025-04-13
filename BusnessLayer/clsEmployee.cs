using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BusnessLayer
{
    public class clsEmployee
    {
        enum EnMode { Update,Addnew}
        EnMode _mode = EnMode.Update;
        public int Id { get; set; }
        public double salary { get; set; }
        public DateTime hiredate { get; set; }
        public DateTime? firedate { get; set; }
        public clsUser createdbyuserID { get; set; }
        public clsPerson person { get; set; }
        public clsEmployeeRole role { get; set; }
        public clsEmployee()
        {
            Id = 0;
            salary = 0;
            hiredate = DateTime.MinValue;
            firedate = null;
            createdbyuserID = null;
            person = null;
            role = null;
            _mode = EnMode.Addnew;
        }

        bool _AddNew()
        {
            Id = clsEmployeeDataAccess.Create(salary, person.PersonID, hiredate, firedate, createdbyuserID.userID, role.roleID);
            return Id > 0; 
        }
        bool _Update()
        {
           return clsEmployeeDataAccess.Update(Id, salary, role.roleID);
        }
        clsEmployee( int id, double salary, DateTime hiredate, DateTime? firedate, int? createdbyuserID, int person, int role)
        {
            _mode = EnMode.Update;
            Id = id;
            this.salary = salary;
            this.hiredate = hiredate;
            this.firedate = firedate;
            this.createdbyuserID =(createdbyuserID != null)? clsUser.Find(Convert.ToInt32(createdbyuserID)) : null;
            this.person = clsPerson.Find( person);
            this.role = clsEmployeeRole.Find( role);
        }
        public static DataTable GetSpecial()
        {
            return clsEmployeeDataAccess.GetSpecial();
        }
        public static clsEmployee Find( int id )
        {
            double salary = 0;
            DateTime hiredate = DateTime.Now;
            DateTime? firedate = null;
            int? createdbyuserID = 0;
            int person = 0;
            int role = 0;
            return (clsEmployeeDataAccess.Find(id, ref salary, ref person, ref hiredate, ref firedate, ref createdbyuserID, ref role) ? new clsEmployee(id, salary, hiredate, firedate, createdbyuserID, person, role) : null);
        }
        public static clsEmployee Find(string fullname)
        {
            int id = 0;
            double salary = 0;
            DateTime hiredate = DateTime.Now;
            DateTime? firedate = null;
            int? createdbyuserID = 0;
            int person = 0;
            int role = 0;
            return (clsEmployeeDataAccess.Find(fullname , ref id, ref salary, ref person, ref hiredate, ref firedate, ref createdbyuserID, ref role) ? new clsEmployee(id, salary, hiredate, firedate, createdbyuserID, person, role) : null);
        }

        public bool Save()
        {
            if(_mode == EnMode.Update)
            {
                return _Update();
            }
            else
            {
                return _AddNew();
            }
        }
      
        public static bool FireEmployee(int emplID)
        {
            return clsEmployeeDataAccess.Update(emplID);
        }
        public static bool IsExist(int personID)
        {
            return clsEmployeeDataAccess.IsExist(personID);
        }

    }
}
