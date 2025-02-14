using System;

namespace BlazorEFIdentity.Data
{
    public class Transaction
    {
        // Primary key for the transaction
        public int TransactionId { get; set; }

        // Transaction amount (positive for deposits, negative for withdrawals)
        public decimal Amount { get; set; }

        // Date and time of the transaction
        public DateTime Date { get; set; }

        // Required description of the transaction
        public required string Description { get; set; }
        
        // Foreign key to link transaction to an account
        public int AccountId { get; set; }

        // Navigation property to the account this transaction belongs to
        public Account? Account { get; set; }
    }
} 