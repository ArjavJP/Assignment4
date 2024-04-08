using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment4
{
    public partial class AddTransaction : Form
    {
        private int userId;
        private opeartion operations;
        private int? transactionId;
        public AddTransaction(int userId, opeartion operations, int? transactionId = null)
        {
            InitializeComponent();
            this.userId = userId;
            this.operations = operations;
            this.transactionId = transactionId;
            if (transactionId != null)
            {
                // If transactionId is provided, populate the form with existing transaction details
                PopulateForm();
            }
        }
        private void PopulateForm()
        {
            var transaction = operations.GetTransactionById((int)transactionId);
            if (transaction != null)
            {
                txtaccid.Text = transaction.AccountId.ToString();
                txtamount.Text = transaction.Amount.ToString();
                txtdescp.Text = transaction.Description;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal amount;
            if (!decimal.TryParse(txtamount.Text, out amount) || amount <= 0)
            {
                MessageBox.Show("Invalid amount. Please enter a valid positive number.");
                return;
            }

            string description = txtdescp.Text;

            int accountId;
            if (!int.TryParse(txtaccid.Text, out accountId))
            {
                MessageBox.Show("Invalid account ID. Please enter a valid number.");
                return;
            }

            if (transactionId == null)
            {
                // Add new transaction
                operations.AddTransaction(accountId, amount, description);
            }
            else
            {
                // Update existing transaction
                operations.UpdateTransaction((int)transactionId, amount, description);
            }

            MessageBox.Show("Transaction saved successfully.");
            this.Close();
        }
    }
}
