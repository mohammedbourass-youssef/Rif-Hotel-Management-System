using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class clsEmployessSalaryPaymentDataAccess
    {
        //Is the Employee Payed 
         static public bool IsPayedInThisMonth(int EmpID , DateTime checkedate)
         {
             bool result = false;
             using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
             {
                 string query = @"SELECT [dbo].[IsEmployeePayed] (@EmoloyeeID,@CheckedDate) As Result";
                 using (SqlCommand command = new SqlCommand(query, connection))
                 {
                     command.Parameters.AddWithValue("@EmoloyeeID", EmpID);
                     command.Parameters.AddWithValue("@CheckedDate", checkedate);
                     try
                     {
                         connection.Open();
                         object obj = command.ExecuteScalar();
                         if (obj != null && bool.TryParse(obj.ToString(), out bool ID))
                             result = ID;
                     }
                     catch (Exception ex)
                     {
                        string msg = ex.Message;
                     }
                     finally { connection.Close(); }
                     return result;
                 }
             }
         }
    }
}
