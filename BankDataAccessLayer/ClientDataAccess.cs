using System;
using System.Data;
using System.Data.SqlClient;

namespace BankDataAccessLayer
{
    public class clsClientDataAccess
    {
        public static DataTable GetAllClients()
        {
            DataTable dtClients = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM Clients order by AccountNumber";
            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dtClients.Load(reader);
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

            return dtClients;
        }
        public static bool GetClientInfoByAccountNumber(string AccountNumber, ref int ClientID, ref short PinCode, ref double Balance, ref int UserID, ref int PersonID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM Clients WHERE AccountNumber = @AccountNumber;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@AccountNumber", AccountNumber);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if(reader.Read())
                {
                    isFound = true;

                    ClientID = (int)reader["ClientID"];
                    PinCode = (short)reader["PinCode"];
                    UserID = (int)reader["UserID"];
                    PersonID = (int)reader["PersonID"];
                    Balance = Convert.ToDouble(reader["Balance"]);
                }
                else
                {
                    isFound = false;
                }

                reader.Close();
            }

            catch(Exception ex)
            {
                isFound = false;
            }

            finally
            {
                connection.Close();
            }

            return isFound;
        }

        public static bool GetClientInfoByID(int ClientID, ref string AccountNumber, ref short PinCode, ref double Balance, ref int UserID, ref int PersonID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM Clients WHERE ClientID = @ClientID;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ClientID", ClientID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    AccountNumber = (string)reader["AccountNumber"];
                    PinCode = (short)reader["PinCode"];
                    UserID = (int)reader["UserID"];
                    PersonID = (int)reader["PersonID"];
                    Balance = Convert.ToDouble(reader["Balance"]);
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
        public static int AddNewClient(string AccountNumber, short PinCode, double Balance, int UserID, int PersonID)
        {
            int ClientID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"INSERT INTO Clients
                             VALUES (@AccountNumber, @PinCode, @Balance, @UserID, @PersonID);
                             SELECT SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@AccountNumber", AccountNumber);
            command.Parameters.AddWithValue("@PinCode", PinCode);
            command.Parameters.AddWithValue("@Balance", Balance);
            command.Parameters.AddWithValue("@UserID", UserID);
            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if(result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    ClientID = insertedID;
                }
            }
            catch (Exception ex)
            {

            }

            finally
            {
                connection.Close();
            }

            return ClientID;
        }
        public static bool UpdateClient(int ClientID, string AccountNumber, short PinCode, double Balance, int UserID, int PersonID)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"UPDATE Clients
                             SET AccountNumber = @AccountNumber,
                                 PinCode = @PinCode,
                                 Balance = @Balance,
                                 UserID = @UserID,
                                 PersonID = @PersonID
                             WHERE ClientID = @ClientID;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ClientID", ClientID);
            command.Parameters.AddWithValue("@AccountNumber", AccountNumber);
            command.Parameters.AddWithValue("@PinCode", PinCode);
            command.Parameters.AddWithValue("@Balance", Balance);
            command.Parameters.AddWithValue("@UserID", UserID);
            command.Parameters.AddWithValue("@PersonID", PersonID);

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
        public static bool DeleteClient(int ClientID)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "DELETE Clients WHERE ClientID = @ClientID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ClientID", ClientID);

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
        public static bool IsClientExists(int ClientID)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT 1 FROM Clients WHERE ClientID = @ClientID;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ClientID", ClientID);

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
     
    }
}
