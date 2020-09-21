using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsShop.Utils
{
    class SqlUtils
    {
        private static SqlUtils sqlUtils;
        public string conString { get; set; }
        private SqlUtils()
        {
            conString = ConfigurationManager.ConnectionStrings["MainConString"].ConnectionString;
        }

        public static SqlUtils GetInstance()
        {
            if (sqlUtils == null)
            {
                sqlUtils = new SqlUtils();
            }
            return sqlUtils;
        }

        public DataTable GetDataWitAdapter(string query)
        {
            SqlConnection sqlConnection = new SqlConnection(conString);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);
            DataTable dtTable = new DataTable();
            sqlDataAdapter.Fill(dtTable);
            return dtTable;
        }

        //Ve ya sadece bele yazabilerik. ferqi yoxdur
        //
        //public static string conString { get; set; } = ConfigurationManager.ConnectionStrings["MainConString"].ConnectionString;
    }
}
