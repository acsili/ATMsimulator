using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMsimulator.DataBaseConnection
{
    internal class DBConnection
    {
        private static string connectString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"D:\\C Projs\\ATMsimulator\\ATMsimulator\\СlientСardDB.mdb\"";
        public OleDbConnection connection;

        public DBConnection()
        {
            connection = new OleDbConnection(connectString);
        }
        public void OpenConnection()
        {
            connection.Open();
        }
        public void CloseConnection()
        {
            connection.Close();
        }

        
    }
}
