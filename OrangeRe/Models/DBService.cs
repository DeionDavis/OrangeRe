using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
namespace Trio.DAL
{
     public class DBService
    {
        /// <summary>
        /// Global Variables
        /// </summary>
        #region Global Variables
        public SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Connection"].ToString());
        public SqlCommand command = new SqlCommand();
        public SqlDataAdapter dataAdapter = new SqlDataAdapter();
        public DataSet ds = new DataSet();
        public DataTable dt = new DataTable();
        public SqlDataReader dataReader;

        public int retVal = 0;

        #endregion

        /// <summary>
        /// Public Functions
        /// </summary>
        #region Public Functions

        #region Get Database Connection

        public SqlConnection GetConnection()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
                connection.Open();

            }
            else
                connection.Open();
            return connection;
        }
        #endregion

        /// <summary>
        /// Function for Executing Nonqueries with CommandText
        /// </summary>
        /// <param name="cmdTxt"></param>
        /// <returns></returns>
        #region Execute Non Query-CommandText

        public int ExeNonQryCmdTxt(string cmdTxt)
        {
            command.Connection = GetConnection();
            command.CommandType = CommandType.Text;
            command.CommandText = cmdTxt;
            retVal = command.ExecuteNonQuery();
            CloseConnection();
            return retVal;
        }
        #endregion

        /// <summary>
        /// Function for Executing Nonqueries with StoreProcedure
        /// </summary>
        /// <param name="cmdTxt"></param>
        /// <returns></returns>
        #region Execute Non Query - SP

        public int ExeNonQrySP(string cmdTxt)
        {
            command.Connection = GetConnection();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = cmdTxt;
            retVal = command.ExecuteNonQuery();
            CloseConnection();
            return retVal;
        }
        #endregion

        /// <summary>
        /// Function for Executing Scalar with StoreProcedure
        /// </summary>
        /// <param name="cmdTxt"></param>
        /// <returns></returns>
        #region Execute Non Query - SP

        public int ExeScalarSP(string cmdTxt)
        {
            command.Connection = GetConnection();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = cmdTxt;
            retVal = Convert.ToInt32(command.ExecuteScalar());
            CloseConnection();
            return retVal;
        }
        #endregion


        /// <summary>
        /// Function for Getting Dataset with CommandText
        /// </summary>
        /// <param name="cmdTxt"></param>
        /// <returns></returns>
        #region Get Data table using Command Text

        public DataTable GetDataTableCmdTxt(string cmdTxt)
        {
            dt.Clear();
            command.Connection = GetConnection();
            command.CommandType = CommandType.Text;
            command.CommandText = cmdTxt;
            dataAdapter.SelectCommand = command;
            dataAdapter.Fill(dt);
            CloseConnection();
            return dt;
        }
        #endregion

        /// <summary>
        /// Function for Getting Dataset with SP
        /// </summary>
        /// <param name="cmdTxt"></param>
        /// <returns></returns>
        #region Get Data table using SP

        public DataTable GetDataTableSP(string cmdTxt)
        {
            dt.Clear();
            dt.Columns.Clear();
            dt.Rows.Clear();
            command.Connection = GetConnection();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = cmdTxt;
            dataAdapter.SelectCommand = command;
            dataAdapter.Fill(dt);
            CloseConnection();
            return dt;
        }
        #endregion

        /// <summary>
        /// Function for Getting Details using DataReader with CommandText
        /// </summary>
        /// <param name="cmdTxt"></param>
        /// <returns></returns>
        #region Get DataReader with CommandText

        public SqlDataReader GetReaderCmdTxt(string cmdTxt)
        {

            command.Connection = GetConnection();
            command.CommandType = CommandType.Text;
            command.CommandText = cmdTxt;
            dataReader = command.ExecuteReader();
            return dataReader;

        }
        #endregion

        /// <summary>
        /// Function for Getting Details using DataReader with CommandText
        /// </summary>
        /// <param name="cmdTxt"></param>
        /// <returns></returns>
        #region Get DataReader with SP

        public SqlDataReader GetReaderSP(string cmdTxt)
        {
            command.Connection = GetConnection();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = cmdTxt;
            dataReader = command.ExecuteReader();
            return dataReader;

        }
        #endregion

        #endregion
        /// <summary>
        /// Function to get database connection
        /// </summary>
        /// <returns></returns>
        #region Get Database Connection

        public void CloseConnection()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }

        }
        #endregion

        /// <summary>
        /// Function for Getting Dataset with SP
        /// </summary>
        /// <param name="cmdTxt"></param>
        /// <returns></returns>
        #region Get Data Set using SP

        public DataSet GetDataSetSP(string cmdTxt)
        {
            ds.Clear();
            command.Connection = GetConnection();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = cmdTxt;
            dataAdapter.SelectCommand = command;
            dataAdapter.Fill(ds);
            CloseConnection();
            return ds;
        }
        #endregion
    }
}
