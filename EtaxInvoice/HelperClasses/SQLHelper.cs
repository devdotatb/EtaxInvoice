using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EtaxInvoice
{
    public static class SQLHelper
    {
        public static string SafeGetString(this SqlDataReader reader, int colIndex)
        {
            if (!reader.IsDBNull(colIndex))
                return reader.GetString(colIndex);
            return string.Empty;
        }
        public static DateTime SafeGetDate(this SqlDataReader reader, int colIndex)
        {
            if (!reader.IsDBNull(colIndex))
                return Convert.ToDateTime(reader[colIndex]);
            return DateTime.Today;
        }
        public static string SafeGetDateToString(this SqlDataReader reader, int colIndex)
        {
            if (!reader.IsDBNull(colIndex))
                return Convert.ToDateTime(reader[colIndex]).ToString("yyyy-MM-dd HH:mm:ss");
            return string.Empty;
        }
        public static int SafeGetInt(this SqlDataReader reader, int colIndex)
        {
            if (!reader.IsDBNull(colIndex))
                return reader.GetInt32(colIndex);
            return 0;
        }
        public static double SafeGetDouble(this SqlDataReader reader, int colIndex)
        {
            if (!reader.IsDBNull(colIndex))
                return reader.GetDouble(colIndex);
            return 0;
        }
        public static decimal SafeGetDecimal(this SqlDataReader reader, int colIndex)
        {
            if (!reader.IsDBNull(colIndex))
                return (decimal)reader.GetDouble(colIndex);
            return 0;
        }

        public static void UpdateEmail(string FTCstEmail, string FTCstCode)
        {
            try
            {
                string connectionString = ConfigHelper.ConnectionString;
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Open the connection
                    connection.Open();

                    // Create a new command
                    SqlCommand command = connection.CreateCommand();

                    // Set the command text
                    // This is the query that will insert the data into the TPSTLogETAX table
                    command.CommandText = "update TCNMCst set FTCstEmail = @FTCstEmail where FTCstCode = @FTCstCode";

                    // Add the parameters for the query
                    command.Parameters.AddWithValue("@FTCstEmail", FTCstEmail);
                    command.Parameters.AddWithValue("@FTCstCode", FTCstCode);

                    command.ExecuteNonQuery();

                    connection.Close();
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}
