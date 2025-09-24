using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankDataAccessLayer
{
    public class clsCurrencyDataAccess
    {
        public static DataTable GetAllCurrencies()
        {
            DataTable dtCurrencies = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM Currencies order by CurrencyID";
            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dtCurrencies.Load(reader);
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

            return dtCurrencies;
        }

        public static bool UpdateRate(string Code, double Rate)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"UPDATE Currencies
                             SET Rate = @Rate
                             WHERE Code = @Code;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Code", Code);
            command.Parameters.AddWithValue("@Rate", Rate);

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

        public static int AddNewCurrency(string Country, string Code, string Name, double Rate)
        {
            int CurrencyID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"INSERT INTO Currencies
                             VALUES (@Country, @Code, @Name, @Rate);
                             SELECT SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Country", Country);
            command.Parameters.AddWithValue("@Code", Code);
            command.Parameters.AddWithValue("@Name", Name);
            command.Parameters.AddWithValue("@Rate", Rate);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    CurrencyID = insertedID;
                }
            }
            catch (Exception ex)
            {

            }

            finally
            {
                connection.Close();
            }

            return CurrencyID;
        }

        public static bool GetCurrencyByCode(string Code, ref int CurrencyID, ref string Country, ref string Name, ref double Rate)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM Currencies WHERE Code = @Code;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Code", Code);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    CurrencyID = (int)reader["CurrencyID"];
                    Country = (string)reader["Country"];
                    Name = (string)reader["Name"];
                    Rate = Convert.ToDouble(reader["Rate"]);
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

    }
}
