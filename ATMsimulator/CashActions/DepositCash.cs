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
    public partial class DepositCash : Form
    {
        public static string connectString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"D:\\C Projs\\ATMsimulator\\ATMsimulator\\СlientСardDB.mdb\"";
        private OleDbConnection connection;
        public DepositCash()
        {
            InitializeComponent();
            connection = new OleDbConnection(connectString);
            connection.Open();
        }
        private void DepositCash_FormClosing(object sender, FormClosingEventArgs e)
        {
            connection.Close();
        }
        private void buttonEnterAmount_Click(object sender, EventArgs e)
        {
            string requestPastBalance = $"SELECT [balance] FROM ClientCard WHERE PIN = '{LogIn.PIN}'";
            OleDbCommand commandPastBalance = new OleDbCommand(requestPastBalance, connection);
            string pastBalance = commandPastBalance.ExecuteScalar().ToString();

            double balance = Convert.ToDouble(textBoxEnterAmount.Text) + Convert.ToDouble(pastBalance);
            string requestNewBalance = $"UPDATE ClientCard SET [balance] = {balance} WHERE PIN = '{LogIn.PIN}'";
            OleDbCommand commandCardNumber = new OleDbCommand(requestNewBalance, connection);
            commandCardNumber.ExecuteNonQuery();
            MessageBox.Show($"{textBoxEnterAmount.Text} deposited successfully\nBalance: {balance}");
        }

        private void button100_Click(object sender, EventArgs e)
        {
            textBoxEnterAmount.Text = "100";
        }

        private void button1000_Click(object sender, EventArgs e)
        {
            textBoxEnterAmount.Text = "1000";
        }

        private void button1500_Click(object sender, EventArgs e)
        {
            textBoxEnterAmount.Text = "1500";
        }

        private void button3000_Click(object sender, EventArgs e)
        {
            textBoxEnterAmount.Text = "3000";
        }
    }
}
