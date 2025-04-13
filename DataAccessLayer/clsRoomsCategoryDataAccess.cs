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
    public class clsRoomsCategoryDataAccess
    {
        static public bool Find(string name, ref int ID ,ref string Category , ref double Price )
        {
            bool result = false;
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {
                string query = @"select *from RoomCategories Where Category = @C";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@C", name);
                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            ID = Convert.ToInt32(reader["ID"]);
                            Category = Convert.ToString(reader["Category"]);
                            Price = Convert.ToDouble(reader["Price"]);
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
        static public DataTable Get()
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {
                string query = "EXEC [dbo].[SP_RetreiveRoomsCategoriesSpecial]";
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
    }
}
