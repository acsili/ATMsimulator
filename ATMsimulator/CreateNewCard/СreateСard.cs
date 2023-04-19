using ATMsimulator.DataBaseConnection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATMsimulator
{
    
    public partial class СreateСard : Form
    {

        DBConnection dBConnection = new DBConnection();

        public СreateСard()
        {
            InitializeComponent();
            dBConnection.OpenConnection();
        }

        private void СreateСard_FormClosing(object sender, FormClosingEventArgs e)
        {
            dBConnection.CloseConnection();
        }

        private string GenerateCardNumber()
        {
            string cardNumber = "";
            
            Random random = new Random();
            for (int i = 1; i <= 20; i++)
            {
                int value = random.Next(0, 9);
                if (i > 4)
                {
                    
                    cardNumber += value;
                    if (i % 4 == 0 && i != 20)
                    {
                        cardNumber += " ";
                    }
                }
            }
            return cardNumber;
        }

        private string GeneratePIN()
        {
            string PIN = "";
            
            Random random = new Random();
            for (int i = 1; i <= 4; i++)
            {
                int value = random.Next(0, 9);
                PIN += value;
                
            }
            return PIN;
        }

        private void buttonCraeteCard_Click(object sender, EventArgs e)
        {
            string PIN = GeneratePIN();
            string name = textBoxName.Text;
            string surname = textBoxSurname.Text;
            string cardNumber = GenerateCardNumber();
            double balance = 0.0;
            
            string myFirstRequest = "INSERT INTO ClientCard (client_name, client_surname, " +
                "card_number, [balance], PIN) VALUES ('" + name + "', '" + surname + "', " +
                "'" + cardNumber + "', " + balance + ", '" + PIN + "')";
            OleDbCommand command = new OleDbCommand(myFirstRequest, dBConnection.connection);
            command.ExecuteNonQuery();

            MessageBox.Show($"PIN {PIN}\nCard number {cardNumber}");
            
            /*string requestIdCard = $"SELECT [id_cc] FROM ClientCard WHERE PIN = {PIN}";
            OleDbCommand commandIdCard = new OleDbCommand(requestIdCard, connection);

            var _idCard = commandIdCard.ExecuteScalar().ToString();
            int idCard = Convert.ToInt32(_idCard);

            string operation = "BankCardCreated";
            string date = "dfg";
            
            string mySecondRequest = "INSERT INTO OperationsHistory (operation, date, " +
                "[id_card]) VALUES ('" + operation + "', '" + date + "', " + idCard + ")";
            OleDbCommand _command = new OleDbCommand(mySecondRequest, connection);
            string strFeedback = "";
            try
            {
                strFeedback = _command.ExecuteNonQuery().ToString() + " record has been added successfully!";
            }
            catch (Exception ex)
            {

                strFeedback = "ERROR: " + ex.Message;
            }
*/
            //_command.ExecuteNonQuery();
            
            //MessageBox.Show("OK");
        }
    }
}
