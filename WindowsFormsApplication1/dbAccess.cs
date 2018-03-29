using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WindowsFormsApplication1
{
    class dbAccess
    {
        
      

        private static string _connString = @" Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Asad Mehmood\Desktop\New folder (3)\WindowsFormsApplication1\WindowsFormsApplication1\Database.mdf;Integrated Security=True";

        private static SqlConnection _dbConn = new SqlConnection(_connString);

        private static SqlCommand _dbCommand;
        private static SqlDataAdapter _dataAdapter;

        private static void CreateConnection(string ConnectionString)
        // private static void CreateConnection(string _conn)
        {
            try
            {
                _dbConn = new SqlConnection();
                _dbConn.ConnectionString = ConnectionString;
                _dbConn.Open();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private static void CloseConnection()
        {
            try
            {
                _dbConn.Close();
            }
            catch (Exception ex)
            { throw ex; }
        }

        public static DataTable ReadDataFromDb(string query)
        {
            try
            {

                CreateConnection(_connString);

                _dbCommand = new SqlCommand();
                _dbCommand.CommandText = query;

                _dbCommand.Connection = _dbConn;

                _dataAdapter = new SqlDataAdapter();
                _dataAdapter.SelectCommand = _dbCommand;

                DataTable _dataTable = new DataTable();
                _dataAdapter.Fill(_dataTable);

                CloseConnection();

                return _dataTable;

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}