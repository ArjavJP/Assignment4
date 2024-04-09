using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment4.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Assignment4
{
   
    public class opeartion
    {
        private MMABooksContext dbContext;
        public opeartion()
        {
            dbContext = new MMABooksContext();
        }
        public int AuthenticateUser(string username, string password)
        {
            var user = dbContext.Users.FirstOrDefault(u => u.Email == username && u.Password == password);
            return user != null ? user.Id : 0; // Return user ID if authentication successful, otherwise 0
        }

    

        public void AddTransaction(int accountId, decimal amount, string description)
        {
            var account = dbContext.Accounts.FirstOrDefault(a => a.AccountId == accountId);
            if (account != null)
            {
                // Debit the account balance
                account.CurrentBalance = ((double)(account.CurrentBalance ?? 0) - (double)amount);
                // Add transaction
                var transaction = new TransactionHistory
                {
                    AccountId = accountId,
                    Amount = amount, // Negative amount indicates debit
                    Description = description
                };

                dbContext.TransactionHistories.Add(transaction);
                dbContext.SaveChanges();
            }
        }
        public TransactionHistory GetTransactionById(int transactionId)
        {
            return dbContext.TransactionHistories.FirstOrDefault(t => t.TransactionId == transactionId);
        }
        public void UpdateTransaction(int transactionId, decimal newAmount, string newDescription)
        {
            var transaction = dbContext.TransactionHistories.FirstOrDefault(t => t.TransactionId == transactionId);
            if (transaction != null)
            {
                // Get the current transaction amount before updating
                decimal oldAmount = (decimal)transaction.Amount;

                // Update transaction details
                transaction.Amount = newAmount;
                transaction.Description = newDescription;
                dbContext.SaveChanges();

                // Calculate the difference between old and new amount
                decimal difference = newAmount - oldAmount;

                // Update the current balance in the account table based on transaction type
                var account = dbContext.Accounts.FirstOrDefault(a => a.AccountId == transaction.AccountId);
                if (account != null)
                {
                    if (newDescription.ToLower().Contains("deposit"))
                    {
                        // If the transaction description contains "deposit", add the difference to the current balance
                        account.CurrentBalance += (double)difference;
                    }
                    else if (newDescription.ToLower().Contains("withdraw"))
                    {
                        // If the transaction description contains "withdraw", deduct the difference from the current balance
                        account.CurrentBalance -= (double)difference;
                    }
                    dbContext.SaveChanges();
                }
            }
        }

        public void DeleteTransaction(int transactionId)
        {
            var transaction = dbContext.TransactionHistories.FirstOrDefault(t => t.TransactionId == transactionId);
            if (transaction != null)
            {
                // Credit the account balance
                var account = dbContext.Accounts.FirstOrDefault(a => a.AccountId == transaction.AccountId);
                if (account != null)
                {
                    account.CurrentBalance += (double)transaction.Amount;
                }

                // Delete transaction
                dbContext.TransactionHistories.Remove(transaction);
                dbContext.SaveChanges();
            }
        }
        public List<object> GetUserAccountTransactions(int userId)
{
    var query = from transaction in dbContext.TransactionHistories
                join account in dbContext.Accounts on transaction.AccountId equals account.AccountId
                join user in dbContext.Users on account.UserId equals user.Id
                where account.UserId == userId
                select new
                {
                    TransactionId = transaction.TransactionId,
                    AccountId = transaction.AccountId,
                    FirstName = user.Firstname,
                    LastName = user.Lastname,
                    Amount = transaction.Amount,
                    CurrentBalance = account.CurrentBalance,
                    Description = transaction.Description,
                    TransactionDate = transaction.TransactionDate,
                };

    return query.ToList<object>();
}
    }
}
