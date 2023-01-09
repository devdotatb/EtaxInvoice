using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EtaxInvoice
{
    public class LogInserter
    {
        public static void InsertLog(LogETAX data)
        {
            try
            {
                // Replace YOUR_CONNECTION_STRING with your actual connection string
                string connectionString = ConfigHelper.ConnectionString;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Open the connection
                    connection.Open();

                    // Create a new command
                    SqlCommand command = connection.CreateCommand();

                    // Set the command text
                    // This is the query that will insert the data into the TPSTLogETAX table
                    command.CommandText = "INSERT INTO TPSTLogETAX (FDDateIns, FTTimeIns, FTWhoIns, FTRemark, FTBchCode, FTDeviceID, FTShdDocNo, FDShdDocDate, FTShdDocType, FTReqType, FNStep, FTServiceName, FTReqPara, FTResPara, FTResCode, FTResMsg, FTResShwMsg) VALUES (@FDDateIns, @FTTimeIns, @FTWhoIns, @FTRemark, @FTBchCode, @FTDeviceID, @FTShdDocNo, @FDShdDocDate, @FTShdDocType, @FTReqType, @FNStep, @FTServiceName, @FTReqPara, @FTResPara, @FTResCode, @FTResMsg, @FTResShwMsg)";

                    // Add the parameters for the query
                    command.Parameters.AddWithValue("@FDDateIns", data.FDDateIns);
                    command.Parameters.AddWithValue("@FTTimeIns", data.FTTimeIns);
                    command.Parameters.AddWithValue("@FTWhoIns", data.FTWhoIns);
                    command.Parameters.AddWithValue("@FTRemark", data.FTRemark);
                    command.Parameters.AddWithValue("@FTBchCode", data.FTBchCode);
                    command.Parameters.AddWithValue("@FTDeviceID", data.FTDeviceID);
                    command.Parameters.AddWithValue("@FTShdDocNo", data.FTShdDocNo);
                    command.Parameters.AddWithValue("@FDShdDocDate", data.FDShdDocDate);
                    command.Parameters.AddWithValue("@FTShdDocType", data.FTShdDocType);
                    command.Parameters.AddWithValue("@FTReqType", data.FTReqType);
                    command.Parameters.AddWithValue("@FNStep", data.FNStep);
                    command.Parameters.AddWithValue("@FTServiceName", data.FTServiceName);
                    command.Parameters.AddWithValue("@FTReqPara", data.FTReqPara);
                    command.Parameters.AddWithValue("@FTResPara", data.FTResPara);
                    command.Parameters.AddWithValue("@FTResCode", data.FTResCode);
                    command.Parameters.AddWithValue("@FTResMsg", data.FTResMsg);
                    command.Parameters.AddWithValue("@FTResShwMsg", data.FTResShwMsg);

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
