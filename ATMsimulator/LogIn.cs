using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATMsimulator
{
    public partial class LogIn : Form
    {
        public static string connectString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"D:\\C Projs\\ATMsimulator\\ATMsimulator\\СlientСardDB.mdb\"";
        private OleDbConnection connection;

        public static string name;
        public static string surname;
        public static string PIN;
        public static string cardNumber;
        public static int id;
        public LogIn()
        {
            InitializeComponent();
            connection = new OleDbConnection(connectString);
            connection.Open();
        }
        private void LogIn_FormClosing(object sender, FormClosingEventArgs e)
        {
            connection.Close();
        }
        private void buttonPIN_Click(object sender, EventArgs e)
        {
            PIN = textBoxPIN.Text;

            string requestPIN = $"SELECT id_cc FROM ClientCard WHERE PIN = '{PIN}'";
            OleDbCommand commandPIN = new OleDbCommand(requestPIN, connection);

            if (commandPIN.ExecuteScalar() != null)
            {
                string requestCardNumber = $"SELECT card_number FROM ClientCard WHERE PIN = '{PIN}'";
                OleDbCommand commandCardNumber = new OleDbCommand(requestCardNumber, connection);
                cardNumber = commandCardNumber.ExecuteScalar().ToString();

                string requestClientName = $"SELECT client_name FROM ClientCard WHERE PIN = '{PIN}'";
                OleDbCommand commandClientName = new OleDbCommand(requestClientName, connection);
                name = commandClientName.ExecuteScalar().ToString();

                string requestClientSurname = $"SELECT client_surname FROM ClientCard WHERE PIN = '{PIN}'";
                OleDbCommand commandClientSurnamer = new OleDbCommand(requestClientSurname, connection);
                surname = commandClientSurnamer.ExecuteScalar().ToString();

                Main main = new Main();  
                main.Owner = this;
                main.Show();
                textBoxPIN.Clear();

            }
            else
            {
                MessageBox.Show("Wrong PIN");
            }
        }

        private void buttonCreateNewCard_Click(object sender, EventArgs e)
        {
            СreateСard сreateСard = new СreateСard();
            сreateСard.Owner = this;
            сreateСard.Show();
        }
    }
}
