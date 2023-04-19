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
using ATMsimulator.DataBaseConnection;
using System.Data.Common;

namespace ATMsimulator
{
    public partial class Main : Form
    {
        DBConnection dBConnection = new DBConnection();
        public Main()
        {
            InitializeComponent();
            dBConnection.OpenConnection();
            labelNameSurname.Text = $"{LogIn.name} {LogIn.surname}";
            labelCardNumber.Text = LogIn.cardNumber;
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            dBConnection.CloseConnection();
        }

        private void buttonEndSession_Click(object sender, EventArgs e)
        {
            dBConnection.CloseConnection();
            this.Close();
        }

        private void buttonBalance_Click(object sender, EventArgs e)
        {
            string requestBalance = $"SELECT balance FROM ClientCard WHERE PIN = '{LogIn.PIN}'";
            OleDbCommand commandBalance = new OleDbCommand(requestBalance, dBConnection.connection);
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
