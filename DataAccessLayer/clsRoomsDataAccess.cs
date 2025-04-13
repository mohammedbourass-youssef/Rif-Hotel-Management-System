using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class clsRoomsDataAccess_
    {
        static public DataTable Get()
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {
                string query = "EXEC [dbo].[SP_GetAllRooms]";
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
        static public DataTable GetAllRoomOcuppent(string roomnumber)
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {
                string query = "select * from [dbo].[AllRoomOccupant] (@roomID)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@roomID", roomnumber);  
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
        static public bool SetForMantence(string roomnumber)
        {
            bool result = false;
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {
                string query = @"DECLARE	@return_value int

EXEC	@return_value = [dbo].[SP_SetForMantenace]
		@roomnumber = @RomNumber

SELECT	'Return Value' = @return_value";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@RomNumber", roomnumber);
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
        static public bool SetForAvailable(string roomnumber)
        {
            bool result = false;
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {
                string query = @"DECLARE	@return_value int

EXEC	@return_value = [dbo].[SP_SetForAvailable]
		@roomnumber = @RomNumber

SELECT	'Return Value' = @return_value";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@RomNumber", roomnumber);
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
        static public int CountNumberOfAvailbeRooms()
        {
            int result = -1;
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {
                string query = @"SELECT  Count(*) FROM Rooms WHERE RoomStatus = 1 ;";
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

        static public bool Find(int ID, ref string roomnumber)
        {
            bool result = false;
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {
                string query = @"SELECT[dbo].[GetRoomStatus_By_RoomID](@RoomNumber) AS RoomNumber";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@RoomNumber", ID);
                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            roomnumber = Convert.ToString(reader["RoomNumber"]);
                            if (ID == -1)
                            {
                                result = false;
                            }
                            else
                            {
                                result = true;
                            }
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
        static public bool Find(string roomnumber,ref int ID)
        {
            bool result = false;
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {
                string query = @"SELECT dbo.GetRoomID_By_RoomStatus(@RoomNumber) AS RoomID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@RoomNumber", roomnumber);
                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            ID = Convert.ToInt32(reader["RoomID"]);
                            if(ID == -1)
                            {
                                result = false;
                            }
                            else
                            {
                                result = true;
                            }
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
        static public bool GetCategory_By_RoomID(int ID, ref string category)
        {
            bool result = false;
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {
                string query = @"SELECT [dbo].GetCategory_By_RoomID(@RoomNumber) AS RoomNumber";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@RoomNumber", ID);
                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            category = Convert.ToString(reader["RoomNumber"]);
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


    }
}
