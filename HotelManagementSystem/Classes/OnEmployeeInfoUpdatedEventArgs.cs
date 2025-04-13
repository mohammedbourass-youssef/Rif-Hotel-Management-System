using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusnessLayer;

namespace HotelManagementSystem.Classes
{
    public class OnEmployeeInfoUpdatedEventArgs : EventArgs
    {
        public double Salary { get; set; }
        public DateTime HireDate { get; set; }



        public clsEmployeeRole Role { get; set; }
        public OnEmployeeInfoUpdatedEventArgs(double salary, DateTime hireDate, clsEmployeeRole EmployeeRole)
        {
            Salary = salary;
            HireDate = hireDate;
            Role = EmployeeRole;
        }
    }
}
