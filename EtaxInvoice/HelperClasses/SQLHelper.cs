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
    }
}
