using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Azure;

namespace Assignment4
{
    public partial class TransactionHistoryform : Form
    {
        private int userId;
        private opeartion op = new opeartion();

        public TransactionHistoryform(int userId)
        {
            InitializeComponent();
            this.userId = userId;

            LoadAccountDetails();
            LoadTransactionHistory();
        }

        private void TransactionHistory_Load(object sender, EventArgs e)
        {

        }
        private void LoadAccountDetails()
        {
            //var account = accountOperations.GetAccountDetails(userId);
            //if (account != null)
            //{
            //    lblBalance.Text = account.CurrentBalance?.ToString("C");
            //}
        }

        private void LoadTransactionHistory()
        {

            var transactions = op.GetUserAccountTransactions(userId);

            dgv_history.DataSource = transactions;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var addTransactionForm = new AddTransaction(userId, op);
            addTransactionForm.ShowDialog();

            // Reload transaction history after adding the new transaction
            dgv_history.Rows.Clear();
            LoadTransactionHistory();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var selectedRow = dgv_history.CurrentRow;
            if (selectedRow == null)
            {
                MessageBox.Show("Please select a transaction to update.");
                return;
            }

            int transactionId = (int)selectedRow.Cells["TransactionId"].Value;
            var updateTransactionForm = new AddTransaction(userId, op, transactionId);
            updateTransactionForm.ShowDialog();

            // Reload transaction history after updating the transaction
        
            LoadTransactionHistory();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var selectedRow = dgv_history.CurrentRow;
            if (selectedRow == null)
            {
                MessageBox.Show("Please select a transaction to delete.");
                return;
            }

            int transactionId = (int)selectedRow.Cells["TransactionId"].Value;
            op.DeleteTransaction(transactionId);

            // Reload transaction history after deleting the transaction

            LoadTransactionHistory();
        }
    }
}
