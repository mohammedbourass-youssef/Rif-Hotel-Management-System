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
    public class clsPayementMethodDataAccess
    {

        static public DataTable Get()
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {
                string query = "EXEC GetAllPaymentMethods;";
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

        static public bool Find(int ID,ref string MethodName , ref string Description)
        {
            bool result = false;
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {
                string query = @"EXEC GetPaymentMethodByID @MethodID = @ID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ID", ID);
                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            MethodName = Convert.ToString(reader["MethodName"]);
                            Description = Convert.ToString(reader["Description"]);
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
