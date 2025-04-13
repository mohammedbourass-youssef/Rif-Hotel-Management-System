using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class clspersonDataAccess
    {
        //delete 
        static public bool Delete(int personID)
        {
            bool result = false;

            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {
                string query = @"DELETE FROM [dbo].[People]
                      WHERE PersonID = @personID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@personID", personID);
                    try
                    {
                        connection.Open();
                        result = command.ExecuteNonQuery() > 0;
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
        //Update 
        static public bool Update(int personID , string firstname, string secondname, string lastname, string email, string phone, int userID, int countryID, string nationnalnumber, string passportnumber, int gender, string picturepath)
        {
           bool result = false;
           using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
           {
               string query = @"EXECUTE [dbo].[SP_UpdatePerson] 
                               @PersonID = @personID,
                               @FirstName = @firstname,
                                @SecondName = @secondname,
                                @LastName = @lastname,
                                @Email = @email,
                                @Phone = @phone,
                                @CountryID = @countryID,
                                @NationalNumber = @nationnalnumber,
                                @PassportNumber = @passportnumber,
                                @PicturePath = @image,
                                @Gender = @sex";
               using (SqlCommand command = new SqlCommand(query, connection))
               {
                    command.Parameters.AddWithValue("@personID", personID);
                    command.Parameters.AddWithValue("@firstname", firstname);
                    command.Parameters.AddWithValue("@secondname", secondname);
                    if (!string.IsNullOrEmpty(picturepath))
                    {
                        command.Parameters.AddWithValue("@image", picturepath);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@image", DBNull.Value);
                    }
                    command.Parameters.AddWithValue("@sex", gender);
                    command.Parameters.AddWithValue("@lastname", lastname);
                    if (!string.IsNullOrEmpty(email))
                    {
                        command.Parameters.AddWithValue("@email", email);
                    }
                    else
                        command.Parameters.AddWithValue("@email", DBNull.Value);
                    command.Parameters.AddWithValue("@phone", phone);
                    command.Parameters.AddWithValue("@userID", userID);
                    command.Parameters.AddWithValue("@countryID", countryID);
                    if (!string.IsNullOrEmpty(nationnalnumber))
                    {

                        command.Parameters.AddWithValue("@nationnalnumber", nationnalnumber);
                    }
                    else
                        command.Parameters.AddWithValue("@nationnalnumber", DBNull.Value);
                    if (!string.IsNullOrEmpty(passportnumber))
                    {
                        command.Parameters.AddWithValue("@passportnumber", passportnumber);
                    }
                    else
                        command.Parameters.AddWithValue("@passportnumber", DBNull.Value);

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
        // ADD
        static public int Create(string firstname,string secondname,string lastname,string email,string phone,int userID ,int countryID,string nationnalnumber,string passportnumber,int gender , string picturepath)
        {
            int lastid = 0;
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {
                string query = @"DECLARE	@return_value int

                         EXEC	@return_value = [dbo].[SP_AddNewPerson]
		                        @FirstName = @firstname,
		                        @SecondName = @secondname,
		                        @LastName = @lastname,
		                        @Email = @email,
		                        @Phone = @phone,
		                        @CreatedByUserID = @userID,
		                        @CountryID = @countryID,
		                        @NationalNumber = @nationnalnumber,
		                        @PassportNumber = @passportnumber,
                                @PicturePath = @image
		                        ,@Gender = @sex
                                SELECT	'Return Value' = @return_value"; //Add the function Using 
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@firstname", firstname);
                    command.Parameters.AddWithValue("@secondname", secondname);
                    if (!string.IsNullOrEmpty(picturepath))
                    {
                        command.Parameters.AddWithValue("@image", picturepath);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@image", DBNull.Value);
                    }
                    command.Parameters.AddWithValue("@sex", gender);
                    command.Parameters.AddWithValue("@lastname", lastname);
                    if(!string.IsNullOrEmpty(email))
                    {
                        command.Parameters.AddWithValue("@email", email);
                    }
                    else
                        command.Parameters.AddWithValue("@email", DBNull.Value);
                    command.Parameters.AddWithValue("@phone", phone);
                    command.Parameters.AddWithValue("@userID", userID);
                    command.Parameters.AddWithValue("@countryID", countryID);
                    if (!string.IsNullOrEmpty(nationnalnumber))
                    {
                        command.Parameters.AddWithValue("@nationnalnumber", nationnalnumber);
                    }
                    else
                        command.Parameters.AddWithValue("@nationnalnumber", DBNull.Value);
                    if (!string.IsNullOrEmpty(passportnumber))
                    {
                        command.Parameters.AddWithValue("@passportnumber", passportnumber);
                    }
                    else
                        command.Parameters.AddWithValue("@passportnumber", DBNull.Value);

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
        // Find 
        static public bool Find(int personID,ref string firstname,ref string secondname,ref string lastname,ref string email,ref string phone,ref int createdbyuserID,ref int countryID,ref string nationnalnumber,ref string passsportnumber,ref string picturepath, ref int gender)
        {
            bool result = false;
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {
                string query = @"EXEC [dbo].[SP_FindPersonByID]
		@PersonID = @ID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ID", personID);
                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            firstname = Convert.ToString(reader["FirstName"]);
                            secondname = Convert.ToString(reader["SecondName"]);
                            lastname = Convert.ToString(reader["LastName"]);
                            phone = Convert.ToString(reader["Phone"]);
                            if (reader["Email"] != DBNull.Value)
                                email = Convert.ToString(reader["Email"]);
                            else
                                email = null;
                            if (reader["NationalNumber"] != DBNull.Value)
                                nationnalnumber = Convert.ToString(reader["NationalNumber"]);
                            else
                                nationnalnumber = "Unvailable";
                            if (reader["PassportNumber"] != DBNull.Value)
                                passsportnumber = Convert.ToString(reader["PassportNumber"]);
                            else
                                passsportnumber = "Unvailable";
                            if (reader["PicturePath"] != DBNull.Value)
                                picturepath = Convert.ToString(reader["PicturePath"]);
                            else
                                picturepath = null;
                            createdbyuserID = Convert.ToInt32(reader["CreatedByUserID"]);
                            countryID = Convert.ToInt32(reader["CountryID"]);
                            gender = Convert.ToInt32(reader["Gender"]);
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
        static public bool Find(string nationnalnumber,ref string firstname,ref string secondname,ref string lastname,ref string email,ref string phone,ref int createdbyuserID,ref int countryID,ref int personID, ref string passsportnumber,ref string picturepath, ref int gender)
        {
            bool result = false;
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {
                string query = @"EXEC	[dbo].[SP_FindPersonByNationnalNumber]
		@NationalNumber = @nationalNo";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@nationalNo", nationnalnumber);
                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            firstname = Convert.ToString(reader["FirstName"]);
                            personID = Convert.ToInt32(reader["PersonID"]);
                            secondname = Convert.ToString(reader["SecondName"]);
                            lastname = Convert.ToString(reader["LastName"]);
                            phone = Convert.ToString(reader["Phone"]);
                            if (reader["Email"] != DBNull.Value)
                                email = Convert.ToString(reader["Email"]);
                            else
                                email = null;

                            if (reader["PassportNumber"] != DBNull.Value)
                                passsportnumber = Convert.ToString(reader["PassportNumber"]);
                            else
                                passsportnumber = "Unvailable";
                            if (reader["PicturePath"] != DBNull.Value)
                                picturepath = Convert.ToString(reader["PicturePath"]);
                            else
                                picturepath = null;
                            createdbyuserID = Convert.ToInt32(reader["CreatedByUserID"]);
                            countryID = Convert.ToInt32(reader["CountryID"]);
                            gender = Convert.ToInt32(reader["Gender"]);
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
        static public bool FindByPassport(string passportnumber, ref string firstname, ref string secondname, ref string lastname, ref string email, ref string phone, ref int createdbyuserID, ref int countryID, ref int personID, ref string nationnalnumber, ref string picturepath, ref int gender)
        {
            bool result = false;
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {
                string query = @"EXEC[dbo].[SP_FindPersonByPassportNumber]

        @PassportNumber = @passportno";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@passportno", passportnumber);
                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            firstname = Convert.ToString(reader["FirstName"]);
                            personID = Convert.ToInt32(reader["PersonID"]);
                            secondname = Convert.ToString(reader["SecondName"]);
                            lastname = Convert.ToString(reader["LastName"]);
                            phone = Convert.ToString(reader["Phone"]);
                            if (reader["Email"] != DBNull.Value)
                                email = Convert.ToString(reader["Email"]);
                            else
                                email = null;

                            if (reader["NationalNumber"] != DBNull.Value)
                                nationnalnumber = Convert.ToString(reader["NationalNumber"]);
                            else
                                nationnalnumber = "Unvailable";
                            if (reader["PicturePath"] != DBNull.Value)
                                picturepath = Convert.ToString(reader["PicturePath"]);
                            else
                                picturepath = null;
                            createdbyuserID = Convert.ToInt32(reader["CreatedByUserID"]);
                            countryID = Convert.ToInt32(reader["CountryID"]);
                            gender = Convert.ToInt32(reader["Gender"]);
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
        static public DataTable RetrieveAllPeopleForManagePeople()
         {
           DataTable dt = new DataTable();
           using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
           {
               string query = "EXEC [dbo].[SP_ReTreiveAllPeople]";
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

        //Is Exist 
        static public bool IsPersonHasAnReservations(int personID)
        {
            bool result = false;
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {
                string query = @"Select  dbo.IsPersonHasAnReservations(@personID) as Exist";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@personID", personID);
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
        static public bool IsExist(string nationnalnumber)
         {
             bool result = false;
             using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
             {
                 string query = @"Select  found = 1 from People Where NationalNumber = @nationnalNumber  ";
                 using (SqlCommand command = new SqlCommand(query, connection))
                 {
                     command.Parameters.AddWithValue("@nationnalNumber", nationnalnumber);
                     try
                     {
                         connection.Open();
                         object obj = command.ExecuteScalar();
                         if (obj != null && int.TryParse(obj.ToString(), out int ID))
                             result = ID == 1;
                     }
                     catch (Exception ex)
                     {

                     }
                     finally { connection.Close(); }
                     return result;
                 }
             }
         }
        static public bool IsExistByPassportNumber(string passportNumber)
        {
            bool result = false;
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {
                string query = @"Select  found = 1 from People Where PassportNumber = @PassportNumber";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PassportNumber", passportNumber);
                    try
                    {
                        connection.Open();
                        object obj = command.ExecuteScalar();
                        if (obj != null && int.TryParse(obj.ToString(), out int ID))
                            result = ID == 1;
                    }
                    catch (Exception ex)
                    {

                    }
                    finally { connection.Close(); }
                    return result;
                }
            }
        }

    }
}
