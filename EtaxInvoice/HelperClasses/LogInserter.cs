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
        public static void InterfaceInsertLog(LogETAX data)
        {
            decimal step = CheckDoc(data.FTShdDocNo);
            data.FNStep = step + 1;
            InsertLog(data);
        }
        private static void InsertLog(LogETAX data)
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

        private static decimal CheckDoc(string FTShdDocNo)
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
                    command.CommandText = "select top 1 FNStep from TPSTLogETAX where FTShdDocNo = @FTShdDocNo order by FNStep DESC";

                    // Add the parameters for the query
                    command.Parameters.AddWithValue("@FTShdDocNo", FTShdDocNo);

                    SqlDataReader reader = command.ExecuteReader();
                    decimal FNStep = -1;
                    while (reader.Read())
                    {
                        FNStep = SQLHelper.SafeGetDecimal(reader, 0);
                    }

                    connection.Close();

                    return FNStep;
                }
            }
            catch (Exception ex)
            {
                return -1;
            }
        }


        public static void InsertAccessLog(LogAccessETAX data)
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
                    command.CommandText = @"INSERT INTO [dbo].[TPSTLogAccessETAX]
                           ([FDDateIns]
                           ,[FTBranchNumber]
                           ,[FTPOSServer]
                           ,[FTDBName]
                           ,[FTPOSServerLogin]
                           ,[FTPOSServerPassword]
                           ,[FTStartUserPassword]
                           ,[FTStartUserName]
                           ,[FTProgramMode])
                     VALUES
                           (@FDDateIns,
                           @FTBranchNumber,
                           @FTPOSServer,
                           @FTDBName,
                           @FTPOSServerLogin,
                           @FTPOSServerPassword,
                           @FTStartUserPassword,
                           @FTStartUserName,
                           @FTProgramMode)";

                    // Add the parameters for the query
                    command.Parameters.AddWithValue("@FDDateIns", data.FDDateIns);
                    command.Parameters.AddWithValue("@FTBranchNumber", data.FTBranchNumber);
                    command.Parameters.AddWithValue("@FTPOSServer", data.FTPOSServer);
                    command.Parameters.AddWithValue("@FTDBName", data.FTDBName);
                    command.Parameters.AddWithValue("@FTPOSServerLogin", data.FTPOSServerLogin);
                    command.Parameters.AddWithValue("@FTPOSServerPassword", data.FTPOSServerPassword);
                    command.Parameters.AddWithValue("@FTStartUserPassword", data.FTStartUserPassword);
                    command.Parameters.AddWithValue("@FTStartUserName", data.FTStartUserName);
                    command.Parameters.AddWithValue("@FTProgramMode", data.FTProgramMode);

                    command.ExecuteNonQuery();

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageHelper.ShowError(ex.Message);
            }
        }

    }
}
