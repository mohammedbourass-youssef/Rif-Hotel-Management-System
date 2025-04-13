using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
namespace DataAccessLayer
{
    public class clsUsersDataAccess
    {
        //CRUD Functions 

        // 1. Create 
        static public int Create(int employeeID, string username, string password, int createdbyuserID, int permission)
        {
            int lastid = 0;
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {
                string query = @"DECLARE	@return_value int ; 
EXEC	@return_value = [dbo].[SP_AddNewUser]
		@UserName = @username,
		@Password = @password,
		@EmployeeID = @emplID,
		@CreatedByUserID = @userID,
		@Permissions = @permissions
 SELECT	'Return Value' = @return_value;"; //Add the function Using 
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@emplID", employeeID);
                    command.Parameters.AddWithValue("@password", password);
                    command.Parameters.AddWithValue("@userID", createdbyuserID);
                    command.Parameters.AddWithValue("@permissions", permission);
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
                          string str = ex.Message;
                    }
                    finally { connection.Close(); }
                    return lastid;
                }

            }

        }
        // 2 . Retreive 
        static public DataTable Get()
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {
                string query = "EXEC [dbo].[SP_ReTreiveAllUsers]";
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
                        string msj = ex.Message;
                    }
                    finally { connection.Close(); }
                    return dt;
                }                  
            }
        }
        // 3 .  Update 
       static public bool Update(int userID,string username, string password, int createdbyuserID, int permission,bool IsActive)
        {
            bool result = false;
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {
                string query = @"UPDATE [dbo].[users]
   SET 
       [UserName] = @UserName
      ,[Password] = @Password
      ,[Permissions] = @Permissions
      ,[IsActive] = @IsActive
 WHERE UserID = @userID ";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@userID", userID);
                    command.Parameters.AddWithValue("@UserName", username);
                    command.Parameters.AddWithValue("@Password", password);
                    command.Parameters.AddWithValue("@Permissions",permission);
                    command.Parameters.AddWithValue("@IsActive",IsActive);
                    try
                    {
                        connection.Open();
                        result = command.ExecuteNonQuery() > 0;
                    }
                    catch (Exception ex)
                    {
                        string str = ex.Message;
                    }
                    finally { connection.Close(); }
                    return result;
                }
            }
             
        }
        // 4. Delete 
        /*static public bool Delete(int personID)
        {
            bool result = false;

            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {
                string query = "";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PersonID", personID);
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
        }*/
        // 5 . Find 
        static public bool Find(string username ,ref int userID, ref int employeeID,ref string password,ref int? createdbyuserID, ref int permissions,ref bool isactive )
        {
            bool result = false;
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {
                string query = @"EXEC [dbo].[SP_FindTheUserUsingUsername] @Username = @username";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            username = Convert.ToString(reader["UserName"]);
                            password = Convert.ToString(reader["Password"]);
                            userID = Convert.ToInt32(reader["UserID"]);
                            employeeID = Convert.ToInt32(reader["EmployeeID"]);
                            if (reader["CreatedByUserID"] != DBNull.Value)
                            {
                                createdbyuserID = Convert.ToInt32(reader["CreatedByUserID"]);
                            }
                            else
                            {
                                createdbyuserID = null;
                            }
                            permissions = Convert.ToInt32(reader["Permissions"]);
                            isactive = Convert.ToBoolean(reader["IsActive"]);

                            result = true;
                        }
                        reader.Close();
                    }
                    catch (Exception ex) {
                        result = false;
                        string msg = ex.Message;
                    }
                    finally { connection.Close(); }
                    return result;
                }
             
            }
           
        }
        static public bool Find(int userID ,ref string username, ref int employeeID, ref string password, ref int? createdbyuserID, ref int permissions,ref bool isactive)
        {
            bool result = false;
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {
                string query = @"EXEC [dbo].[SP_FindTheUserUsingUserID] @ID = @userID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@userID", userID);
                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            username = Convert.ToString(reader["UserName"]);
                            password = Convert.ToString(reader["Password"]);
                            userID = Convert.ToInt32(reader["UserID"]);
                            employeeID = Convert.ToInt32(reader["EmployeeID"]);
                            if (reader["CreatedByUserID"] != DBNull.Value)
                            {
                                createdbyuserID = Convert.ToInt32(reader["CreatedByUserID"]);
                            }
                            else
                            {
                                createdbyuserID = null;
                            }
                            permissions = Convert.ToInt32(reader["Permissions"]);
                            isactive = Convert.ToBoolean(reader["IsActive"]);

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
        // 6 - IsExist
         static public bool IsExist(int UserID)
         {
             bool result = false;
             using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
             {
                 string query = @"select found = 1 from users Where EmployeeID = @userID";
                 using (SqlCommand command = new SqlCommand(query, connection))
                 {
                     command.Parameters.AddWithValue("@userID", UserID);
                     try
                     {
                         connection.Open();
                         object obj = command.ExecuteScalar();
                         if (obj != null && int.TryParse(obj.ToString(), out int ID))
                             result = ID == 1;
                     }
                     catch (Exception ex)
                     {
                        string str = ex.Message;
                     }
                     finally { connection.Close(); }
                     return result;
                 }
             }
         }
        static public bool IsExist(string username)
        {
            bool result = false;
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {
                string query = @"select found = 1 from users Where UserName = @userID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@userID", username);
                    try
                    {
                        connection.Open();
                        object obj = command.ExecuteScalar();
                        if (obj != null && int.TryParse(obj.ToString(), out int ID))
                            result = ID == 1;
                    }
                    catch (Exception ex)
                    {
                        string str = ex.Message;
                    }
                    finally { connection.Close(); }
                    return result;
                }
            }
        }
        static public int CountNumberOfUser()
        {
            int result = 0;
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {
                string query = @"select  dbo.CountNumberOfUser() As NumberUser";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        object obj = command.ExecuteScalar();
                        if (obj != null && int.TryParse(obj.ToString(), out int ID))
                            result = ID ;
                    }
                    catch (Exception ex)
                    {
                        string str = ex.Message;
                    }
                    finally { connection.Close(); }
                    return result;
                }
            }
        }
        static public int CountCountGuestsWeHave()
        {
            int result = 0;
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {
                string query = @"select dbo.CountCountGuestsWeHave() AS Number";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        object obj = command.ExecuteScalar();
                        if (obj != null && int.TryParse(obj.ToString(), out int ID))
                            result = ID ;
                    }
                    catch (Exception ex)
                    {
                        string str = ex.Message;
                    }
                    finally { connection.Close(); }
                    return result;
                }
            }
        }
    }
}
