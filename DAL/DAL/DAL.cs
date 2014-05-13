using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL : IDAL
    {
        private string sqlQuery;
        private System.Data.OleDb.OleDbConnection connection;
        private System.Data.OleDb.OleDbCommand command;
        private System.Data.OleDb.OleDbDataAdapter dataAdapter;
        private System.Data.DataSet dataSet;

        public DAL()
        {
            this.sqlQuery = "NC";
            this.connection = new System.Data.OleDb.OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;" +
            @"Data Source=C:\Users\utilisateur1\Documents\Visual Studio 2012\Projects\Prosit6\BDDcocktail.mdb");
            this.command = new System.Data.OleDb.OleDbCommand();
            this.dataAdapter = new System.Data.OleDb.OleDbDataAdapter();
        }

        public System.Data.DataSet getRows(string sqlQuery, string rowsName)
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
        }
    }
}
