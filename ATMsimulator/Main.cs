using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace ATMsimulator
{
    public partial class Main : Form
    {
        public static string connectString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"D:\\C Projs\\ATMsimulator\\ATMsimulator\\СlientСardDB.mdb\"";
        private OleDbConnection connection;
        public Main()
        {
            InitializeComponent();
            connection = new OleDbConnection(connectString);
            connection.Open();
            labelNameSurname.Text = $"{LogIn.name} {LogIn.surname}";
            labelCardNumber.Text = LogIn.cardNumber;
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            connection.Close();
        }

        private void buttonEndSession_Click(object sender, EventArgs e)
        {
            connection.Close();
            this.Close();
        }

        private void buttonBalance_Click(object sender, EventArgs e)
        {
            string requestBalance = $"SELECT balance FROM ClientCard WHERE PIN = '{LogIn.PIN}'";
            OleDbCommand commandBalance = new OleDbCommand(requestBalance, connection);
            MessageBox.Show($"{commandBalance.ExecuteScalar().ToString()}");
        }

        private void buttonDepositCash_Click(object sender, EventArgs e)
        {
            DepositCash depositCash = new DepositCash();
            depositCash.Owner = this;
            depositCash.Show();

        }

        private void buttonGetCash_Click(object sender, EventArgs e)
        {
            GetCash getCash = new GetCash();
            getCash.Owner = this;
            getCash.Show();
        }
    }
}
