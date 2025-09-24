using System;
using System.Data.SqlClient;
using System.Data;
namespace BankDataAccessLayer
{
    public class clsLoginRegistersDataAccess
    {
        public static DataTable GetAllLoginRegister()
        {
            DataTable dtLoginRegisters = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM LoginRegisters order by LoginRegisterID";
            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dtLoginRegisters.Load(reader);
                }

                reader.Close();
            }

            catch (Exception ex)
            {

            }

            finally
            {
                connection.Close();
            }

            return dtLoginRegisters;
        }
        public static bool GetLoginRegisterInfoByUserName(string UserName, ref int LoginRegisterID, ref DateTime Date, ref string Password, ref int Permissions)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM LoginRegisters WHERE UserName = @UserName;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserName", UserName);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    LoginRegisterID = (int)reader["LoginRegisterID"];
                    Date = (DateTime)reader["DateTime"];
                    Password = (string)reader["Password"];
                    Permissions = (int)reader["Permissions"];
                }
                else
                {
                    isFound = false;
                }

                reader.Close();
            }

            catch (Exception ex)
            {
                isFound = false;
            }

            finally
            {
                connection.Close();
            }

            return isFound;
        }
        public static int AddNewLoginRegister(DateTime Date, string UserName, string Password, int Permissions)
        {
            int LoginRegisterID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"INSERT INTO LoginRegisters
                             VALUES (@Date, @UserName, @Password, @Permissions);
                             SELECT SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Date", Date);
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@Permissions", Permissions);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    LoginRegisterID = insertedID;
                }
            }
            catch (Exception ex)
            {

            }

            finally
            {
                connection.Close();
            }

            return LoginRegisterID;
        }
        public static bool UpdateLoginRegister(int LoginRegisterID, DateTime Date, string UserName, string Password, int Permissions)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"UPDATE LoginRegisters
                             SET DateTime = @Date,
                                 UserName = @UserName
                                 Password = @Password,
                                 Permissions = @Permissions
                             WHERE LoginRegisterID = @LoginRegisterID;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LoginRegisterID", LoginRegisterID);
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@Permissions", Permissions);

            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();
            }

            catch (Exception ex)
            {

            }

            finally
            {
                connection.Close();
            }

            return (rowsAffected > 0);

        }
        public static bool DeleteLoginRegister(int LoginRegisterID)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "DELETE LoginRegisters WHERE LoginRegisterID = @LoginRegisterID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LoginRegisterID", LoginRegisterID);

            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();
            }

            catch (Exception ex)
            {

            }

            finally
            {
                connection.Close();
            }

            return (rowsAffected > 0);
        }
    }
}
