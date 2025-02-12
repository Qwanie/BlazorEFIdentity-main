using System;

namespace BlazorEFIdentity.Data
{
    public class Transaction
    {
        public int TransactionId { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public required string Description { get; set; }
        
        // Navigation property to Account
        public int AccountId { get; set; }
        public Account? Account { get; set; }
    }
} 