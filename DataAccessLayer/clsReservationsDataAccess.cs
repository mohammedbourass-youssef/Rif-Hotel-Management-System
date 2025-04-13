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
    public class clsReservationsDataAccess
    {
        static public DataTable Get()
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {
                string query = "EXEC [dbo].[SP_GetAllReservationsDetaisl]";
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
        public static int Check_In(int reservationID,int userID,int payemetID)
        {
            int lastid = 0;

            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {
                string query = @" DECLARE @return_value INT; 
                                  EXEC @return_value = [dbo].[SP_CheckIn]
                                                        @reservationID  = @resID,
                                                        @CreatedByUserID = @userID,
	                                                    @PeaymentMethod  = @payementID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@resID", reservationID);
                    command.Parameters.AddWithValue("@userID", userID);
                    command.Parameters.AddWithValue("@payementID", payemetID);
                    
                    try
                    {
                        connection.Open();
                        object result = command.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int ID))
                            lastid = ID;
                    }
                    catch (Exception ex)
                    {
                        string msj = ex.Message;
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }

            return lastid;
        }
        public static int AddNewReservation(int RoomID, int GuestID, int? GuestmateID, int CreatedByUserID, DateTime AppliedDate, DateTime StartDate, DateTime EndDate, int ReservationType, int Status, int? ExtendRoomID,int PayementID)
        {
            int lastid = 0;

            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {
                string query = @"
            DECLARE @return_value INT;
            EXEC @return_value = [dbo].[SP_CreateNewReservation]
                @RoomID = @rmID,
                @PersonID = @prID,
                @CreatedByUserID = @UserID,
                @AppliedDate = @applDate,
                @StartDate = @stDate,
                @EndDate = @endDate,
                @ReservationType = @Type,
                @Status = @status,
                @CompanionID = @mateID,
                @ExtendResID = @extendID,
                @PeaymentMethod = @payementMethodID;
            SELECT @return_value;";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@rmID", RoomID);
                    command.Parameters.AddWithValue("@prID", GuestID);
                    command.Parameters.AddWithValue("@UserID", CreatedByUserID);
                    command.Parameters.AddWithValue("@applDate", AppliedDate);
                    command.Parameters.AddWithValue("@payementMethodID", PayementID);
                    command.Parameters.AddWithValue("@stDate", StartDate);
                    command.Parameters.AddWithValue("@endDate", EndDate);
                    command.Parameters.AddWithValue("@Type", ReservationType);
                    command.Parameters.AddWithValue("@status", Status);
                    if (GuestmateID.HasValue)
                        command.Parameters.AddWithValue("@mateID",GuestmateID.Value);
                    else
                        command.Parameters.AddWithValue("@mateID", DBNull.Value);
                    if (ExtendRoomID.HasValue)
                        command.Parameters.AddWithValue("@extendID", ExtendRoomID.Value);
                    else
                        command.Parameters.AddWithValue("@extendID", DBNull.Value);
                    try
                    {
                        connection.Open();
                        object result = command.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(), out int ID))
                            lastid = ID;
                    }
                    catch (Exception ex)
                    {
                        string msj = ex.Message;
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }

            return lastid;
        }

        public static int ExtendReservation(int RoomID, int GuestID, int? GuestmateID, int CreatedByUserID, DateTime AppliedDate, DateTime StartDate, DateTime EndDate, int ReservationType, int Status, int? ExtendRoomID)
        {
            int lastid = 0;

            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {
                string query = @"
            DECLARE @return_value INT;
            EXEC @return_value = [dbo].[SP_ExtendNewReservation]
                @RoomID = @rmID,
                @GuestID = @prID,
                @CreatedByUserID = @UserID,
                @AppliedDate = @applDate,
                @StartDate = @stDate,
                @EndDate = @endDate,
                @ReservationType = @Type,
                @Status = @status,
                @CompanionID = @mateID,
                @ExtendResID = @extendID;
            SELECT @return_value;";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@rmID", RoomID);
                    command.Parameters.AddWithValue("@prID", GuestID);
                    command.Parameters.AddWithValue("@UserID", CreatedByUserID);
                    command.Parameters.AddWithValue("@applDate", AppliedDate);
                    command.Parameters.AddWithValue("@stDate", StartDate);
                    command.Parameters.AddWithValue("@endDate", EndDate);
                    command.Parameters.AddWithValue("@Type", ReservationType);
                    command.Parameters.AddWithValue("@status", Status);
                    if (GuestmateID.HasValue)
                        command.Parameters.AddWithValue("@mateID", GuestmateID.Value);
                    else
                        command.Parameters.AddWithValue("@mateID", DBNull.Value);
                        command.Parameters.AddWithValue("@extendID", ExtendRoomID.Value);
                    try
                    {
                        connection.Open();
                        object result = command.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(), out int ID))
                            lastid = ID;
                    }
                    catch (Exception ex)
                    {
                        string msj = ex.Message;
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }

            return lastid;
        }

       
        static public bool CanCancel(int reservationID)
        {
            bool result = false;
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {
                string query = @"SELECT dbo.CanCancel(@reservationID) As Result";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@reservationID", reservationID);
                    try
                    {
                        connection.Open();
                        object obj = command.ExecuteScalar();
                        if (obj != null && bool.TryParse(obj.ToString(), out bool ID))
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
        static public bool IsThisGuestHasAnActiveReservation(int guestID,DateTime date)
        {
            bool result = false;
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {
                string query = @"SELECT  dbo.IsThisGuestHasAnActiveReservation (@GuestID,@date) As Result";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@GuestID", guestID);
                    command.Parameters.AddWithValue("@date", date);
                    try
                    {
                        connection.Open();
                        object obj = command.ExecuteScalar();
                        if (obj != null && bool.TryParse(obj.ToString(), out bool ID))
                            result = ID;
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
        static public bool CanCheckIN(int reservationID)
        {
            bool result = false;
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {
                string query = @"SELECT [dbo].[Can_CheckIn](@reservationID) As Result";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@reservationID", reservationID);
                    try
                    {
                        connection.Open();
                        object obj = command.ExecuteScalar();
                        if (obj != null && bool.TryParse(obj.ToString(), out bool ID))
                            result = ID;
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
        static public bool CanCheckOut(int reservationID)
        {
            bool result = false;
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {
                string query = @"SELECT [dbo].[Can_CheckOut](@reservationID) As Result";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@reservationID", reservationID);
                    try
                    {
                        connection.Open();
                        object obj = command.ExecuteScalar();
                        if (obj != null && bool.TryParse(obj.ToString(), out bool ID))
                            result = ID;
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

        static public bool Cancel(int reservationID)
        {
            bool result = false;
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {
                string query = @"DECLARE	@return_value int

                            EXEC	@return_value = [dbo].[SP_CancelReservation]
		                    @reservationID = @resID

                             SELECT	'Return Value' = @return_value";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@resID", reservationID);

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
        public static bool CancelNonCheckInReservations()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand("CancelNonCheckInReservations", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        int rowsAffected = cmd.ExecuteNonQuery(); // Get the number of affected rows

                        return rowsAffected > 0; // Return true if at least one row was updated
                    }
                }
            }
            catch (Exception ex)
            {
                return false; // Return false if an error occurs
            }
        }

        static public bool Find(int ReservationID, ref int RoomID, ref int GuestID, ref int? GuestmateID, ref int CreatedByUserID, ref DateTime AppliedDate, ref DateTime StartDate, ref DateTime EndDate, ref int ReservationType, ref int Status, ref int? ExtendRoomID)
        {
            bool result = false;
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {
                string query = @"EXEC [dbo].[SP_FindReservationByID] @ID = @XID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@XID", ReservationID);
                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            RoomID = Convert.ToInt32(reader["RoomID"]);
                            GuestID = Convert.ToInt32(reader["GuestID"]);
                            if (reader["CompanionID"] != DBNull.Value)
                                GuestmateID = Convert.ToInt32(reader["CompanionID"]);
                            else
                                GuestmateID = null;
                            CreatedByUserID = Convert.ToInt32(reader["CreatedByUserID"]);
                            AppliedDate = Convert.ToDateTime(reader["AppliedDate"]);
                            StartDate = Convert.ToDateTime(reader["StartDate"]);
                            EndDate = Convert.ToDateTime(reader["EndDate"]);
                            ReservationType = Convert.ToInt32(reader["ReservationType"]);
                            Status = Convert.ToInt32(reader["Status"]);
                            if (reader["ExtendResID"] != DBNull.Value)
                                ExtendRoomID = Convert.ToInt32(reader["ExtendResID"]);
                            else
                                ExtendRoomID = null;
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

        public static int Check_Out(int reservationID)
        {
            int lastid = 0;

            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {
                string query = @" DECLARE	@return_value int

                                  EXEC	@return_value = [dbo].[SP_CheckOut]
	                                	@reservationID = @resID

                                   SELECT	'Return Value' = @return_value";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@resID", reservationID);

                    try
                    {
                        connection.Open();
                        object result = command.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int ID))
                            lastid = ID;
                    }
                    catch (Exception ex)
                    {
                        string msj = ex.Message;
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }

            return lastid;
        }
        public static int TodaysCheckIn()
        {
            int lastid = 0;

            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {
                string query = @"SELECT [dbo].[TodaysCheckIn]() AS NumberOFCheckouters";

                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    try
                    {
                        connection.Open();
                        object result = command.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int ID))
                            lastid = ID;
                    }
                    catch (Exception ex)
                    {
                        string msj = ex.Message;
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }

            return lastid;
        }
        public static int TodaysCheckOut()
        {
            int lastid = 0;

            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {
                string query = @"SELECT [dbo].[TodaysCheckOut]() AS NumberOFCheckouters";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                
                    try
                    {
                        connection.Open();
                        object result = command.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int ID))
                            lastid = ID;
                    }
                    catch (Exception ex)
                    {
                        string msj = ex.Message;
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }

            return lastid;
        }
        static public DataTable GetAvailableForDateAndCategory(DateTime date ,int  categoryID)
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {
                string query = @"
SELECT RoomNumber ,CASE 
                      WHEN AvailbleDaysForThisDate Is null or AvailbleDaysForThisDate<0 Then 'Unlimited'
					  ELSE CAST(AvailbleDaysForThisDate as VARCHAR) 
					  END AS [Availble Days For This Date]
FROM [dbo].[AvailableRoomsOfSpecialCategory]  (
   @Date
  , @categoryID) ";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Date", date);
                    command.Parameters.AddWithValue("@categoryID", categoryID);
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
    }
}
