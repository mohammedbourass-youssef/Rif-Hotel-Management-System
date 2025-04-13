using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public  class clsEmployeeRoleDataAccess
    {
        //Find
        static public bool Find(int RoleID,ref string rolename,ref string description)
        {
            bool result = false;
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {
                string query = @"EXEC [dbo].[SP_GETEmployeeRoleByID]
		@ID = @roleID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@roleID", RoleID);
                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            rolename = Convert.ToString(reader["RoleName"]);                           
                            if (reader["Description"] != DBNull.Value)
                                description = Convert.ToString(reader["Description"]);
                            else
                                description = null;
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

        //Retreive
        static public DataTable RetreiveAllRolesAndCountEmployee()
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {
                string query = @"EXEC [dbo].[SP_RetreiveAllRolesAndCountEmployee]";
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



    }
}
