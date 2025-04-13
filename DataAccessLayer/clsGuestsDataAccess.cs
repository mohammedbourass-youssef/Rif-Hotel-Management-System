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
    public class clsGuestsDataAccess
    {
        static public DataTable Get()
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {
                string query = "EXEC [dbo].[SP_GetGuestsRecord]";
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
        static public string GetLoyaleGuests()
        {
            string result = null;
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {
                string query = @"WITH GoodGuests AS 
(select TOP 1   GuestID ,COUNT(*) as frequency From Reservtions  
GROUP BY GuestID
ORDER BY frequency DESC 
)
select TRIM(FirstName) +' '+TRIM(SecondName)+' '+TRIM(LastName) AS 'FullName' from GoodGuests JOIN Guests ON GoodGuests.GuestID = Guests.GuestID
                        JOIN People ON People.PersonID = Guests.PersonID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            result = Convert.ToString(reader["FullName"]);
                        }
                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        result = null;
                        string msg = ex.Message;
                    }
                    finally { connection.Close(); }
                    return result;
                }

            }

        }
        static public int Create(int personID)
            {
                int lastid = 0;
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
                {
                    string query = @"DECLARE	@return_value int
                                     EXEC	@return_value = [dbo].[SP_AddNewGuests]
	                             	@PersonID = @perID;
                                    SELECT	'Return Value' = @return_value;"; //Add the function Using 
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                    command.Parameters.AddWithValue("@perID", personID);
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
                            string str = ex.Message;
                        }
                        finally { connection.Close(); }
                        return lastid;
                    }

                }

            }

        static public bool Find(int personID,ref int GuestID,ref DateTime FirstApplieddate)
        {
            bool result = false;
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {
                string query = @"select *from Guests where PersonID = @PersonID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PersonID", personID);
                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            personID = Convert.ToInt32(reader["PersonID"]);
                            GuestID = Convert.ToInt32(reader["GuestID"]);
                            FirstApplieddate = Convert.ToDateTime(reader["FirstAppliedDate"]);
                           
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

        static public DataTable GetTheAnalyticsOfMonth(int month)
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {
                string query = @"select AppliedDate as 'Day',COUNT(*) as 'number Of reservation' from Reservtions
GROUP BY AppliedDate
HAVING MONTH(AppliedDate) = @month";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@month", month);
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
        static public double CountTotalGuestMonth(int month)
        {
            double result = -1;
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {
                string query = @"select COUNT(*) As 'CountTotalGuest' FRom Guests 
WHERE 
GuestID IN (select Distinct CompanionID  from Reservtions 
            WHERE (Status = 3 OR Status = 4) AND @month  in (MONTH(StartDate),MONTH(EndDate)) AND CompanionID IS NOT NULL)
OR 
GuestID IN (select Distinct GuestID  from Reservtions 
              WHERE (Status = 3 OR Status = 4) AND @month in (MONTH(StartDate),MONTH(EndDate)) )";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@month", month);
                    try
                    {
                        connection.Open();
                        object obj = command.ExecuteScalar();
                        if (obj != null && double.TryParse(obj.ToString(), out double ID))
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
        static public bool FindByGuestID(int GuestID, ref int personID , ref DateTime FirstApplieddate)
        {
            bool result = false;
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {
                string query = @"select *from Guests where GuestID = @PersonID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PersonID", GuestID);
                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            personID = Convert.ToInt32(reader["PersonID"]);
                            GuestID = Convert.ToInt32(reader["GuestID"]);
                            FirstApplieddate = Convert.ToDateTime(reader["FirstAppliedDate"]);

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

    }
}
