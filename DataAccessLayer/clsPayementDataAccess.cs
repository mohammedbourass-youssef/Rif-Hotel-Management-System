using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class clsPayementDataAccess
    {
        public static bool FindBookingPrice(int reservationId, ref decimal amount, ref int paymentId, ref DateTime date, ref int paymentMethodId, ref int createdByUserId, ref string description)
        {
            bool result = false;
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {
                string query = @"SELECT * FROM dbo.GetPayementBookingPriceByReservationID(@ID);";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ID", reservationId);
                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            amount = Convert.ToDecimal(reader["Amount"]);
                            paymentId =Convert.ToInt32(reader["PayementID"]);
                            date = Convert.ToDateTime(reader["Date"]);
                            paymentMethodId = Convert.ToInt32(reader["PayementMethodID"]);
                            createdByUserId = Convert.ToInt32(reader["CreatedByUserID"]);
                            if(reader["Description"]!=null)
                                description = reader["Description"].ToString();
                            else
                                description =string.Empty;
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
        public static bool FindTotalPrice(int reservationId, ref decimal amount, ref int paymentId, ref DateTime date, ref int paymentMethodId, ref int createdByUserId, ref string description)
        {
            bool result = false;
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {
                string query = @"SELECT * FROM [dbo].[GetPayementTotalPriceByReservationID](@ID);";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ID", reservationId);
                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            amount = Convert.ToDecimal(reader["Amount"]);
                            paymentId = Convert.ToInt32(reader["PayementID"]);
                            date = Convert.ToDateTime(reader["Date"]);
                            paymentMethodId = Convert.ToInt32(reader["PayementMethodID"]);
                            createdByUserId = Convert.ToInt32(reader["CreatedByUserID"]);
                            if (reader["Description"] != null)
                                description = reader["Description"].ToString();
                            else
                                description = string.Empty;
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
        static public DataTable GetAnalyticsOfThisAllMonths(int month)
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {
                string query = @"SELECT Date, SUM(Amount) AS [Total Income] 
                                           FROM Payement  
                                           GROUP BY Date
                                           HAVING MONTH(Date) = @month
                                           ORDER BY Date";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@month",month);
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
        static public DataTable GetAnalyticsOfThisAllYear(int year)
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {
                string query = @"SELECT 
    MONTH(Date) AS month, 
    SUM(Amount) AS amount 
FROM Payement 
WHERE YEAR(Date) = @year
GROUP BY MONTH(Date);";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@year", year);
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
        static public DataTable GetTheAnalyticsOfPayementMethod()
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {
                string query = @"select MethodName, COUNT(*) AS Number  from Payement 
                     INNER JOIN PaymentMethods ON Payement.PayementMethodID = PaymentMethods.MethodID
GROUP BY MethodName
";
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
        static public DataTable GetPagingAllPayement(int page)
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {
                string query = @"select * from  GetAllPayementPaging(@page)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@page", page);
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
        static public DataTable GetTheAnalyticsOfRoomsCategory()
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {
                string query = @"select Category ,COUNT(*) as number from Reservtions 
        join Rooms ON Rooms.RoomID = Reservtions.RoomID
		JOIN RoomCategories ON RoomCategories.ID = Rooms.CategoryID
GROUP BY Category";
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
        static public DataTable GetTheAnalyticsOfCancelDay(DateTime date)
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {
                string query = @"

WITH Days AS (
    SELECT 1 AS Day
    UNION ALL
    SELECT Day + 1 FROM Days WHERE Day < DAY(EOMONTH(DATEFROMPARTS(@year, @month, 1)))
)
SELECT Days.Day , CASE 
                     WHEN r1.Total IS null THEN 0
					 ELSE r1.Total
					 END AS TotaL 
					 FROM Days left outer join (Select DAY(CancelDate) DAY,COUNT(*) AS Total from Reservtions Where Status = 2
                                      AND MONTH(CancelDate) = @month
GROUP BY CancelDate ) r1 On r1.DAY = Days.Day


";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@month", date.Month);
                    command.Parameters.AddWithValue("@year", date.Year);
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
        static public string GetTheMostUsedMethodOfPayement()
        {
            string result = null;
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {
                string query = @"select  MethodName  from Payement 
                     INNER JOIN PaymentMethods ON Payement.PayementMethodID = PaymentMethods.MethodID
                     GROUP BY MethodName
                     ORDER BY  COUNT(*) DESC";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        object obj = command.ExecuteScalar();
                            result =  obj.ToString();
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
        static public string GetTheMostUsedRoomCategories()
        {
            string result = null;
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {
                string query = @"select TOP 1 Category  from Reservtions 
        join Rooms ON Rooms.RoomID = Reservtions.RoomID
		JOIN RoomCategories ON RoomCategories.ID = Rooms.CategoryID
GROUP BY Category
ORDER BY COUNT(*) DESC";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        object obj = command.ExecuteScalar();
                        result = obj.ToString();
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
        static public string GetTheMostCountry()
        {
            string result = null;
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {
                string query = @"
SELECT CountryName from Countries WHERE CountryID 
                              IN (select TOP 1 CountryID  from Reservtions 
             JOIN Guests ON Reservtions.GuestID = Guests.GuestID
			 JOIN People ON People.PersonID = Guests.PersonID
GROUP BY CountryID
ORDER BY COUNT(*) )";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        object obj = command.ExecuteScalar();
                        result = obj.ToString();
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
        static public double CountOdTotalIncomOfMonth(int month)
        {
            double result = -1;
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {
                string query = @"select SUM(Amount) AS [Total Income]  from Payement
WHERE MONTH(Date) = @month";
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
        static public double CountOdTotalIncomOfDaySpecial(DateTime time)
        {
            double result = 0;
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {
                string query = @"select SUM(Amount) AS total from Payement Where Date = CAST(@GETDATE AS DATE)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@GETDATE", time);
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
        static public double CountOdTotalIncomOfYear(int year)
        {
            double result = -1;
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {
                string query = @"select SUM(Amount) as Price from Payement
Where YEAR(Date) = @year";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@year", year);
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
        static public double CountCanceldReservation(int month)
        {
            double result = -1;
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {
                string query = @"Select COUNT(*) as TOTAL from Reservtions Where Status = 2
                                      AND MONTH(CancelDate) = @year";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@year", month);
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
        static public int CountTotalPayement()
        {
            int result = -1;
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {
                string query = @"SELECT CEILING(COUNT(*) * 1.0 / 10) AS TotalPages
FROM Payement;";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        object obj = command.ExecuteScalar();
                        if (obj != null && int.TryParse(obj.ToString(), out int ID))
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
    }
}
