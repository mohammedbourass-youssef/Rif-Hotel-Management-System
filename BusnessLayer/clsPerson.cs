using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BusnessLayer
{
    public enum EnGender { Male  = 0, Female=1 };
    public class clsPerson
    {
        enum EnMode { Update , Addnew}
        EnMode mode = EnMode.Addnew;
        public int PersonID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SecondName { get; set; }
        public string email {  get; set; }
        public string phone { get; set; }
        public clsCountry country { get; set; }
        public clsUser CreatedByUser { get; set; }
        public string nationnalnumber { get; set; }
        public string passportnumber { get; set; }
        public string picturepath { get; set; }

        public EnGender gender { get; set; }
        bool _AddNew()
        {
            PersonID = clspersonDataAccess.Create(FirstName, SecondName, LastName, email, phone, CreatedByUser.userID, country.CountryId, nationnalnumber, passportnumber,(int)gender,picturepath);
            return PersonID != 0;
        }
        bool _Update()
        {
            if(nationnalnumber == "Unvailable")
                nationnalnumber = string.Empty;
            if(passportnumber == "Unvailable")
                passportnumber = string.Empty;
            return clspersonDataAccess.Update(PersonID, FirstName, SecondName, LastName, email, phone, CreatedByUser.userID, country.CountryId, nationnalnumber, passportnumber, (int)gender, picturepath);
        }
        public clsPerson()
        {
            CreatedByUser = null;
            PersonID = 0;
            FirstName = string.Empty;
            LastName = string.Empty;
            SecondName = string.Empty;
            email = string.Empty;
            phone = string.Empty;
            country = null;
            passportnumber
                = string.Empty;
            picturepath = string.Empty;
            phone = null;
            email = string.Empty;
            nationnalnumber = string.Empty;
             mode = EnMode.Addnew;
        }

        clsPerson(int personID, string firstName, string lastName, string secondName, string email, string phone, int country, int createdByUser, string nationnalnumber, string passportnumber, string picturepath , int gender)
        {
            PersonID = personID;
            FirstName = firstName;
            LastName = lastName;
            SecondName = secondName;
            this.email = email;
            this.phone = phone;
            this.country = clsCountry.Find(country);
            CreatedByUser = clsUser.Find(createdByUser);
            this.nationnalnumber = nationnalnumber;
            this.passportnumber = passportnumber;
            this.picturepath = picturepath;
            this.gender = (EnGender)gender;
            mode = EnMode.Update;
        }

        public string GetFullName()
        {
            return FirstName.Trim() + ' ' +  LastName.Trim();
        }
        public static clsPerson Find(int personID)
        {
            
            string firstName = string.Empty;
            string lastName = string.Empty;
            string secondName = string.Empty;
            string email = string.Empty;
            string phone = string.Empty;
            int country = -1;
            int createdByUser = -1;
            string nationnalnumber = string.Empty;
            string passportnumber = string.Empty;
            string picturepath = string.Empty;
            int gender = -1;
            if (clspersonDataAccess.Find(personID, ref firstName, ref secondName, ref lastName, ref email, ref phone, ref createdByUser, ref country, ref nationnalnumber, ref passportnumber, ref picturepath , ref gender))
                return new clsPerson(personID, firstName, lastName, secondName, email, phone, country, createdByUser, nationnalnumber, passportnumber, picturepath, gender);
            else
                return null;
        }
        public static clsPerson Find(string nationnalNumber)
        {
            int personID = -1;

            string firstName = string.Empty;
            string lastName = string.Empty;
            string secondName = string.Empty;
            string email = string.Empty;
            string phone = string.Empty;
            int country = -1;
            int createdByUser = -1;
            string passportnumber = string.Empty;
            string picturepath = string.Empty;
            int gender = -1;
            if (clspersonDataAccess.Find(nationnalNumber, ref firstName, ref secondName, ref lastName, ref email, ref phone, ref createdByUser, ref country,ref personID , ref passportnumber, ref picturepath, ref gender))
                return new clsPerson(personID, firstName, lastName, secondName, email, phone, country, createdByUser, nationnalNumber, passportnumber, picturepath, gender);
            else
                return null;
        }
        public static clsPerson FindByPassportNumber(string passportnumber )
        {
            int personID = -1;

            string firstName = string.Empty;
            string lastName = string.Empty;
            string secondName = string.Empty;
            string email = string.Empty;
            string phone = string.Empty;
            int country = -1;
            int createdByUser = -1;
            string nationnalNumber = string.Empty;
            string picturepath = string.Empty;
            int gender = -1;
            if (clspersonDataAccess.FindByPassport( passportnumber, ref firstName, ref secondName, ref lastName, ref email, ref phone, ref createdByUser, ref country, ref personID, ref nationnalNumber, ref picturepath, ref gender))
                return new clsPerson(personID, firstName, lastName, secondName, email, phone, country, createdByUser, nationnalNumber, passportnumber, picturepath, gender);
            else
                return null;
        }
        public static bool Delete(int PersonID)
        {
            return clspersonDataAccess.Delete(PersonID);
        }
        public   bool Save()
        {
            if(mode == EnMode.Addnew)
            {
                return _AddNew();
            }
            else 
                return _Update();
        }
        public static DataTable RetrieveAllPeopleForManagePeople()
        {
            return clspersonDataAccess.RetrieveAllPeopleForManagePeople();
        }
        public static bool IsExistByPassportNumber(string passportNumber)
        {
            return clspersonDataAccess.IsExistByPassportNumber(passportNumber);
        }
        public static bool IsExistsByNationnalNumber(string nationnalNumber)
        {
            return clspersonDataAccess.IsExist(nationnalNumber);
        }
        public  bool IsPersonHasAnReservations()
        {
            return clspersonDataAccess.IsPersonHasAnReservations(PersonID);
        }
    }
}
