using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class clsEmployeeDataAccess
    {
        // Create 
        static public int Create(double salary , int personID , DateTime hiredate , DateTime? firedate , int userID , int roleID)
        {
            int lastid = 0;
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {
                string query = @"DECLARE	@return_value int

EXEC	@return_value = [dbo].[SP_AddNewEmployee]
		@Salary = @salary,
		@PersonID = @personID,
		@HireDate = @hiredate,
		@FiredDate = NULL,
		@CreatedByUserID = @userID,
		@RoleID = @roleID
SELECT	'Return Value' = @return_value "; //Add the function Using 
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@salary", salary);
                    command.Parameters.AddWithValue("@personID", personID);
                    command.Parameters.AddWithValue("@hiredate", hiredate);
                    command.Parameters.AddWithValue("@userID", userID);
                    command.Parameters.AddWithValue("@RoleID", roleID);
                    try
                    {
                        connection.Open();
                        object result = command.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int ID))
                            lastid = ID;
                        else
                            lastid = 0;
                    }
                    catch (Exception ex)
                    {
                        //  string logsource =
                        //if (!EventLog.Exists(logsource))
                        //  {
                        //      EventLog.CreateEventSource(logsource, "Application");
                        //     Console.WriteLine(logsource + " Created Succefully ");
                        //  }
                        //  EventLog.WriteEntry(logsource,, EventLogEntryType);
                        string msg = ex.Message;

                    }
                    finally { connection.Close(); }
                    return lastid;
                }

            }

        }
        //update 
        static public bool Update(int empID, double salary ,int RoleID )
        {
            bool result = false;
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {
                string query = @"UPDATE [dbo].[Employees]
   SET [Salary] = @SalaryID
      ,[RoleID] = @roleID
 WHERE EmployeeID = @employeID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@SalaryID", salary);
                    command.Parameters.AddWithValue("@roleID", RoleID);
                    command.Parameters.AddWithValue("@employeID", empID);
                    try
                    {
                        connection.Open();
                        result = command.ExecuteNonQuery() > 0;
                    }
                    catch (Exception ex)
                    {

                    }
                    finally { connection.Close(); }
                    return result;
                }
            }

        }

        //Update Fired Date
        static public bool Update(int empID)
        {
            bool result = false;
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {
                string query = @"

EXEC [dbo].[SP_FireEmployee]
		@emploID = @ID
";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ID", empID);
                    try
                    {
                        connection.Open();
                        result = command.ExecuteNonQuery() > 0;
                    }
                    catch (Exception ex)
                    {

                    }
                    finally { connection.Close(); }
                    return result;
                }
            }

        }

        //Find
        static public bool Find(int employeeID,ref double salary ,ref int personID,ref DateTime hiredate,ref DateTime? firedate,ref int? createdbyuserID,ref int roleID)
        {
            bool result = false;
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {
                string query = @"EXEC [dbo].[SP_FindEmployeeByID]
		@EmployeeID = @ID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ID", employeeID);
                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            personID = Convert.ToInt32(reader["PersonID"]);
                            salary = Convert.ToDouble(reader["Salary"]);
                            hiredate = Convert.ToDateTime(reader["HireDate"]);
                            if (reader["FiredDate"] != DBNull.Value)
                                firedate = Convert.ToDateTime(reader["FiredDate"]);
                            else
                                firedate = null;
                            if (reader["CreatedByUserID"] != DBNull.Value)
                                createdbyuserID = Convert.ToInt32(reader["CreatedByUserID"]);
                            else
                                createdbyuserID = null;
                            roleID = Convert.ToInt32(reader["RoleID"]);
                            employeeID = Convert.ToInt32(reader["EmployeeID"]);
                            result = true;
                        }
                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        result = false;
                        string msg = ex.Message;
                    }
                    finally { connection.Close(); }
                    return result;
                }

            }

        }
        static public bool Find(string fullName, ref int employeeID, ref double salary, ref int personID, ref DateTime hiredate, ref DateTime? firedate, ref int? createdbyuserID, ref int roleID)
        {
            bool result = false;
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {
                string query = @"SELECT        Employees.*
                         FROM            People INNER JOIN
                         Employees ON People.PersonID = Employees.PersonID
                         WHERE (TRIM([FirstName]) + ' ' + Trim([SecondName] )+ ' ' +TRIM( [LastName])) = TRIM(@employeName);";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@employeName", fullName);
                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            employeeID = Convert.ToInt32(reader["EmployeeID"]);
                            personID = Convert.ToInt32(reader["PersonID"]);
                            salary = Convert.ToDouble(reader["Salary"]);
                            hiredate = Convert.ToDateTime(reader["HireDate"]);
                            if (reader["FiredDate"] != DBNull.Value)
                                firedate = Convert.ToDateTime(reader["FiredDate"]);
                            else
                                firedate = null;
                            if (reader["CreatedByUserID"] != DBNull.Value)
                                createdbyuserID = Convert.ToInt32(reader["CreatedByUserID"]);
                            else
                                createdbyuserID = null;
                            roleID = Convert.ToInt32(reader["RoleID"]);
                            employeeID = Convert.ToInt32(reader["EmployeeID"]);
                            result = true;
                        }
                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        result = false;
                        string msg = ex.Message;
                    }
                    finally { connection.Close(); }
                    return result;
                }

            }

        }
        //Retreive AS : EmployeeID , Full Name ,CountryName  ,HireDate ,Salary, RoleName
        static public DataTable GetSpecial()
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {
                string query = @"EXEC SP_GetEmployeesWithSpetialAttribute";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        SqlDataReader Reader = command.ExecuteReader();
                        if (Reader.HasRows)
                        {
                            dt.Load(Reader);
                        }
                        Reader.Close();
                    }
                    catch (Exception ex)
                    {
                        dt = null;
                    }
                    finally { connection.Close(); }
                    return dt;
                }

            }

        }
        // Is Exist 
        static public bool IsExist(int personid)
        {
            bool result = false;
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {
                string query = @"EXEC [dbo].[SP_IsEmployeeExist] @personID = @persID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@persID", personid);
                    try
                    {
                        connection.Open();
                        object obj = command.ExecuteScalar();
                        if (obj != null && int.TryParse(obj.ToString(), out int ID))
                            result = ID == 1;
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

        // IS Admin 
        static public bool IsAdmin(int userID)
        {
            bool result = false;
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {
                string query = @"Select dbo.CheckIsAdminByUserID(@UserID) As found";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserID", userID);
                    try
                    {
                        connection.Open();
                        object obj = command.ExecuteScalar();
                        if (obj != null && bool.TryParse(obj.ToString(), out bool ID))
                            result = ID ;
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
