using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.IO;
using System.Text;

namespace RX108_Data
{
    class DatabaseGateway
    {
        MySqlConnection con;
        MySqlCommand cmd;
        //private const string ROOT_CONNECTION_NAME = "DefaultConnection";
        //AppConfiguration AppConfiguration = new AppConfiguration();
        //MySqlConnection connection = null;
        //SqlDatabase sqlDatabase = null;
        public DatabaseGateway()
        {
            var configurationBuilder = new ConfigurationBuilder();
            var path = Path.Combine(Directory.GetCurrentDirectory(), "appsettings.json");
            configurationBuilder.AddJsonFile(path, false);

            var root = configurationBuilder.Build();
            string _connectionString = root.GetSection("ConnectionStrings").GetSection("DefaultConnection").Value;
            con = new MySqlConnection(_connectionString);
        }
        

        public object ExecuteScalar(string storedProcedureName, params object[] parameterValues)
        {
            //using (DbCommand command = sqlDatabase.GetStoredProcCommand(storedProcedureName, parameterValues))
            //{
            //    return sqlDatabase.ExecuteScalar(command);
            //}
            try
            {
                con.Open();
                MySqlCommand mySqlCommand = new MySqlCommand(storedProcedureName, con);
                mySqlCommand.CommandType = CommandType.StoredProcedure;
                mySqlCommand.Parameters.Clear();
                for (int i = 0; i < parameterValues.Length; i = i + 2)
                {
                    mySqlCommand.Parameters.AddWithValue("@" + parameterValues[i].ToString(), parameterValues[i + 1]);
                    mySqlCommand.Parameters["@" + parameterValues[i].ToString()].Direction = ParameterDirection.Input;
                }

                var returnValue = mySqlCommand.ExecuteScalar();
                con.Close();
                return returnValue;
            }
            catch (Exception ex)
            {
                con.Close();
                throw ex;
            }
        }
        public DataSet ExecuteDataSet(string storedProcedureName, params object[] parameterValues)
        {
            //using (DbCommand command = sqlDatabase.GetStoredProcCommand(storedProcedureName, parameterValues))
            //{
            //    return sqlDatabase.ExecuteDataSet(command);
            //}
            try
            {
                con.Open();
                MySqlCommand mySqlCommand = new MySqlCommand(storedProcedureName, con);
                mySqlCommand.CommandType = CommandType.StoredProcedure;
                mySqlCommand.Parameters.Clear();
                for (int i = 0; i < parameterValues.Length; i = i + 2)
                {
                    mySqlCommand.Parameters.AddWithValue("@" + parameterValues[i].ToString(), parameterValues[i + 1]);
                    mySqlCommand.Parameters["@" + parameterValues[i].ToString()].Direction = ParameterDirection.Input;
                }
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(mySqlCommand);
                DataSet ds = new DataSet();
                mySqlDataAdapter.Fill(ds);
                con.Close();
                return ds;
            }
            catch (Exception ex)
            {
                con.Close();
                throw ex;
            }
        }
        public int ExecuteNonQuery(string storedProcedureName, params object[] parameterValues)
        {
            //using (DbCommand command = sqlDatabase.GetStoredProcCommand(storedProcedureName, parameterValues))
            //{
            //    return sqlDatabase.ExecuteNonQuery(command);
            //}
            try
            {
                con.Open();
                MySqlCommand mySqlCommand = new MySqlCommand(storedProcedureName, con);
                mySqlCommand.CommandType = CommandType.StoredProcedure;
                mySqlCommand.Parameters.Clear();
                for (int i = 0; i < parameterValues.Length; i = i + 2)
                {
                    mySqlCommand.Parameters.AddWithValue("@" + parameterValues[i].ToString(), parameterValues[i + 1]);
                    mySqlCommand.Parameters["@" + parameterValues[i].ToString()].Direction = ParameterDirection.Input;
                }

                var returnValue = mySqlCommand.ExecuteNonQuery();
                con.Close();
                return returnValue;
            }
            catch (Exception ex)
            {
                con.Close();
                throw ex;
            }
        }
        public DataTable QueryForDataTable(string sprocName, params object[] parameters)
        {
            //DataTable table = new DataTable();
            //using (IDataReader reader = ExecuteReader(sprocName, parameters))
            //{
            //    table.Load(reader); //Calls Sproc
            //}
            //return table;
            try
            {
                con.Open();
                MySqlCommand mySqlCommand = new MySqlCommand(sprocName, con);
                mySqlCommand.CommandType = CommandType.StoredProcedure;
                mySqlCommand.Parameters.Clear();
                for (int i = 0; i < parameters.Length; i = i + 2)
                {
                    mySqlCommand.Parameters.AddWithValue("@" + parameters[i].ToString(), parameters[i + 1]);
                    mySqlCommand.Parameters["@" + parameters[i].ToString()].Direction = ParameterDirection.Input;
                }

                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(mySqlCommand);
                DataSet ds = new DataSet();
                mySqlDataAdapter.Fill(ds);
                con.Close();
                return ds.Tables[0];
            }
            catch (Exception ex)
            {
                con.Close();
                throw ex;
            }
        }
        public IDataReader ExecuteReader(string storedProcedureName, params object[] parameterValues)
        {
            //using (DbCommand command = sqlDatabase.GetStoredProcCommand(storedProcedureName, parameterValues)) //Get Sproc Params
            //{
            //    return sqlDatabase.ExecuteReader(command);
            //}
            try
            {
                con.Open();
                MySqlCommand mySqlCommand = new MySqlCommand(storedProcedureName, con);
                mySqlCommand.CommandType = CommandType.StoredProcedure;
                mySqlCommand.Parameters.Clear();
                for (int i = 0; i < parameterValues.Length; i = i + 2)
                {
                    mySqlCommand.Parameters.AddWithValue("@" + parameterValues[i].ToString(), parameterValues[i + 1]);
                    mySqlCommand.Parameters["@" + parameterValues[i].ToString()].Direction = ParameterDirection.Input;
                }
                var returValue = mySqlCommand.ExecuteReader();
                con.Close();
                return returValue;
            }
            catch (Exception ex)
            {
                con.Close();
                throw ex;
            }
        }
        public DataTable QueryForDataTablePaged(string sprocName, int currentPage, int recordsPerPage,
          out int totalRecords, params object[] parameters)
        {
            DataTable table = new DataTable();
            DbCommand dbCom = null;
            //try
            //{
            //    dbCom = sqlDatabase.GetStoredProcCommand(sprocName);
            //    if (parameters != null)
            //    {
            //        for (int i = 0; i < parameters.Length; i += 2)
            //        {
            //            dbCom.Parameters.Add(new SqlParameter(parameters[i].ToString(), parameters[i + 1]));
            //        }
            //    }
            //    sqlDatabase.AddInParameter(dbCom, "@PageNumber", DbType.Int32, currentPage);
            //    sqlDatabase.AddInParameter(dbCom, "@PageSize", DbType.Int32, recordsPerPage);
            //    sqlDatabase.AddOutParameter(dbCom, "@TotalRecords", DbType.Int32, 8);
            //    using (IDataReader reader = sqlDatabase.ExecuteReader(dbCom))
            //    {
            //        table.Load(reader);
            //        totalRecords = (int)sqlDatabase.GetParameterValue(dbCom, "@TotalRecords");
            //    }
            //}
            //finally
            //{
            //    if (dbCom != null)
            //        dbCom.Dispose();
            //}

            try
            {
                con.Open();
                MySqlCommand mySqlCommand = new MySqlCommand(sprocName, con);
                mySqlCommand.CommandType = CommandType.StoredProcedure;
                mySqlCommand.Parameters.Clear();
                for (int i = 0; i < parameters.Length; i = i + 2)
                {
                    mySqlCommand.Parameters.AddWithValue("" + parameters[i].ToString(), parameters[i + 1]);
                    mySqlCommand.Parameters["" + parameters[i].ToString()].Direction = ParameterDirection.Input;
                }
                mySqlCommand.Parameters.AddWithValue("totalrecords", 0);
                mySqlCommand.Parameters["totalrecords"].Direction = ParameterDirection.Output;
                mySqlCommand.Parameters.AddWithValue("pagenumber", currentPage);
                mySqlCommand.Parameters["pagenumber"].Direction = ParameterDirection.Input;
                mySqlCommand.Parameters.AddWithValue("pagesize", recordsPerPage);
                mySqlCommand.Parameters["pagesize"].Direction = ParameterDirection.Input;
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(mySqlCommand);
                DataSet ds = new DataSet();
                mySqlDataAdapter.Fill(ds);
                totalRecords = (int)mySqlCommand.Parameters["totalrecords"].Value;
                con.Close();
                return ds.Tables[0];
            }
            catch (Exception ex)
            {
                con.Close();
                throw ex;
            }
        }
    }
}
