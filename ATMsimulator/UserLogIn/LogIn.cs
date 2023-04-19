using ATMsimulator.DataBaseConnection;
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
        DBConnection dBConnection = new DBConnection();

        public static string name;
        public static string surname;
        public static string PIN;
        public static string cardNumber;
        public static int id;
        public LogIn()
        {
            InitializeComponent();
            dBConnection.OpenConnection();
        }
        private void LogIn_FormClosing(object sender, FormClosingEventArgs e)
        {
            dBConnection.CloseConnection();
        }
        private void buttonPIN_Click(object sender, EventArgs e)
        {
            PIN = textBoxPIN.Text;

            string requestPIN = $"SELECT id_cc FROM ClientCard WHERE PIN = '{PIN}'";
            OleDbCommand commandPIN = new OleDbCommand(requestPIN, dBConnection.connection);

            if (commandPIN.ExecuteScalar() != null)
            {
                string requestCardNumber = $"SELECT card_number FROM ClientCard WHERE PIN = '{PIN}'";
                OleDbCommand commandCardNumber = new OleDbCommand(requestCardNumber, dBConnection.connection);
                cardNumber = commandCardNumber.ExecuteScalar().ToString();

                string requestClientName = $"SELECT client_name FROM ClientCard WHERE PIN = '{PIN}'";
                OleDbCommand commandClientName = new OleDbCommand(requestClientName, dBConnection.connection);
                name = commandClientName.ExecuteScalar().ToString();

                string requestClientSurname = $"SELECT client_surname FROM ClientCard WHERE PIN = '{PIN}'";
                OleDbCommand commandClientSurnamer = new OleDbCommand(requestClientSurname, dBConnection.connection);
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
