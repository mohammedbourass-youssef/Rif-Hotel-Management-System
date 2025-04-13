using System;
using DataAccessLayer;

namespace BusnessLayer
{
    public  class clsEmployessSalaryPayment
    {
        public static bool IsTheEmployeePayedmonth(int EmployeeID , DateTime date)
        {
            return clsEmployessSalaryPaymentDataAccess.IsPayedInThisMonth (EmployeeID, date);
        }
    }
}
