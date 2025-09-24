using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BankDataAccessLayer
{
    public class clsTransferLogDataAccess
    {
        public static DataTable GetAllTransferLog()
        {
            DataTable dtTransferLog = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM TransfersLog order by TransferID";
            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dtTransferLog.Load(reader);
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

            return dtTransferLog;
        }

        public static int AddTransferLog(DateTime Date, string SourceAccountNumber, string DestinationAccountNumber, double SourceBalance,
            double DestinationBalance, double Amount, string UserName)
        {
            int TransferID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"INSERT INTO TransfersLog
                             VALUES (@Date, @SourceAccountNumber, @DestinationAccountNumber, @SourceBalance, @DestinationBalance, @Amount, @UserName);
                             SELECT SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Date", Date);
            command.Parameters.AddWithValue("@SourceAccountNumber", SourceAccountNumber);
            command.Parameters.AddWithValue("@DestinationAccountNumber", DestinationAccountNumber);
            command.Parameters.AddWithValue("@SourceBalance", SourceBalance);
            command.Parameters.AddWithValue("@DestinationBalance", DestinationBalance);
            command.Parameters.AddWithValue("@Amount", Amount);
            command.Parameters.AddWithValue("@UserName", UserName);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    TransferID = insertedID;
                }
            }
            catch (Exception ex)
            {

            }

            finally
            {
                connection.Close();
            }

            return TransferID;
        }
    }
}
