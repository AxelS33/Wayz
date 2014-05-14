using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL : IDAL
    {
      
        private string strConnection;
        private SqlConnection connection;
        private SqlCommand cmd;
        
        
            public DAL()
            {
                this.initConn();
            }


        public void initConn()
        {

            try
            {
                this.strConnection = @"packet size=4096; user id=admin; data source = Francky-PC; persist security info=False; initial catalog=;password=admin";
                this.connection = new SqlConnection(this.strConnection);
            }
            catch(Exception ConnectionFail)
            {
                throw ConnectionFail;
            }
         

        }

        public SqlDataReader getFeatures()
        {
            this.cmd = new SqlCommand();
            this.cmd.Connection = this.connection;

            this.cmd.CommandText = "getAllFeatures";
            this.cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader reader = cmd.ExecuteReader();
            return reader;
            
        }
       
      

        /* public System.Data.DataSet getRows(string sqlQuery, string rowsName)
        {
            this.dataSet = new System.Data.DataSet();
            this.sqlQuery = sqlQuery;
            this.command.Connection = this.connection;
            this.command.CommandText = this.sqlQuery;
            this.dataAdapter.SelectCommand = this.command;
            this.dataAdapter.Fill(this.dataSet, rowsName);
            return this.dataSet;
        }

        public void actionsRows(string sqlQuery)
        {
            this.sqlQuery = sqlQuery;
            this.command.Connection = this.connection;
            this.command.CommandText = this.sqlQuery;
            this.connection.Open();
            this.command.ExecuteNonQuery();
            this.connection.Close();
        }*/
    }
}
