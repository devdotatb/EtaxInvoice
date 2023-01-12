﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
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

        public static string LoadConfig(string configenum)
        {
            var string_return = "";
            string connstr = ConfigHelper.ConnectionString;
            SqlConnection connection = new SqlConnection(connstr);
            string sql = string.Format(@"SELECT FTSysUsrValue FROM TSysConfig WHERE FTSysCode = 'ETAX' AND FTSysSeq = '{0}'", configenum);
            connection.Open();
            SqlCommand cmd = new SqlCommand(sql, connection);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string_return = SQLHelper.SafeGetString(reader, 0);
            }
            return string_return;
        }


        public static string LoaduserLoc()
        {
            var string_return = "";
            string connstr = ConfigHelper.ConnectionString;
            SqlConnection connection = new SqlConnection(connstr);
            string sql = string.Format(@"select top 1 FTBchCode from TCNMComp");
            connection.Open();
            SqlCommand cmd = new SqlCommand(sql, connection);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string_return = SQLHelper.SafeGetString(reader, 0);
            }
            return string_return;
        }

        public static List<Country> LoadCountry()
        {
            string connstr = ConfigHelper.ConnectionString;
            SqlConnection connection = new SqlConnection(connstr);
            string sql = string.Format(@"select FTCYCode,FTCYDescTh,FTCYDescEn from TCNMCountry");
            connection.Open();
            SqlCommand cmd = new SqlCommand(sql, connection);
            SqlDataReader reader = cmd.ExecuteReader();
            var result = new List<Country>();
            while (reader.Read())
            {
                var prov = new Country
                {
                    FTCYCode = SQLHelper.SafeGetString(reader, 0),
                    FTCYDescTh = SQLHelper.SafeGetString(reader, 1),
                    FTCYDescEn = SQLHelper.SafeGetString(reader, 1),
                };
                result.Add(prov);
            }
            return result;
        }
        public static BindingList<ReasonCN> LoadReasonCN()
        {
            string connstr = ConfigHelper.ConnectionString;
            SqlConnection connection = new SqlConnection(connstr);
            string sql = string.Format(@"select FTRsnCNCode,FTRsnCNDescTh,FTRsnCNDescEn from TCNMRsnCN");
            connection.Open();
            SqlCommand cmd = new SqlCommand(sql, connection);
            SqlDataReader reader = cmd.ExecuteReader();
            BindingList<ReasonCN> objects = new BindingList<ReasonCN>();
            while (reader.Read())
            {
                var data = new ReasonCN
                {
                    FTRsnCNCode = SQLHelper.SafeGetString(reader, 0),
                    FTRsnCNDescTh = SQLHelper.SafeGetString(reader, 1),
                    FTRsnCNDescEn = SQLHelper.SafeGetString(reader, 1),
                };
                objects.Add(data);
            }
            return = objects;
        }
    }
}
