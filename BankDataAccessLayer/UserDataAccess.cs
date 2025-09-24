using System;
using System.Data;
using System.Data.SqlClient;

namespace BankDataAccessLayer
{
    public class clsUserDataAccess
    {
        public static bool GetUsersInfoByUserName(string UserName, ref int UserID, ref string Password, ref int Permissions, ref int PersonID, ref bool HasAllAccess)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM Users WHERE UserName = @UserName;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserName", UserName);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    UserID = (int)reader["UserID"];
                    Password = (string)reader["Password"];
                    Permissions = (int)reader["Permissions"];
                    PersonID = (int)reader["PersonID"];
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

        public static bool GetUsersInfoByUserNameAndPassword(string UserName, string Password, ref int UserID, ref int Permissions, ref int PersonID, ref bool HasAllAccess)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM Users WHERE UserName = @UserName and Password = @Password";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Password", Password);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    UserID = (int)reader["UserID"];
                    Permissions = (int)reader["Permissions"];
                    PersonID = (int)reader["PersonID"];
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

        public static bool GetUsersInfoByID(int UserID, ref string UserName, ref string Password, ref int Permissions, ref int PersonID, ref bool HasAllAccess)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM Users WHERE UserID = @UserID;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    UserName = (string)reader["UserName"];
                    Password = (string)reader["Password"];
                    Permissions = (int)reader["Permissions"];
                    PersonID = (int)reader["PersonID"];
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

        public static int AddNewUser(string UserName, string Password, int Permissions, int PersonID, bool HasAllAccess)
        {
            int UserID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"INSERT INTO Users
                             VALUES (@UserName, @Password, @Permissions, @PersonID, @HasAllAccess);
                             SELECT SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@Permissions", Permissions);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@HasAllAccess", HasAllAccess);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    UserID = insertedID;
                }
            }
            catch (Exception ex)
            {

            }

            finally
            {
                connection.Close();
            }

            return UserID;
        }
        public static bool UpdateUser(int UserID, string UserName, string Password, int Permissions, int PersonID, bool HasAllAccess)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"UPDATE Users
                             SET UserName = @UserName,
                                 Password = @Password,
                                 Permissions = @Permissions,
                                 PersonID = @PersonID,
                                 HasAllAccess = @HasAllAccess
                             WHERE UserID = @UserID;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserID", UserID);
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@Permissions", Permissions);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@HasAllAccess", HasAllAccess);

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
        public static bool DeleteUser(int UserID)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "DELETE Users WHERE UserID = @UserID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserID", UserID);

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
        public static bool IsUserExists(int UserID)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT 1 FROM Users WHERE UserID = @UserID;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                isFound = reader.HasRows;
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
        public static DataTable GetAllUsers()
        {
            DataTable dtPersons = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM Users order by UserName";
            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dtPersons.Load(reader);
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

            return dtPersons;
        }
    }
}
