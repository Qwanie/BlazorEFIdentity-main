using System;
using System.Collections.Generic;

namespace BlazorEFIdentity.Data
{
    public class Account
    {
        public Account()
        {
            Transactions = new List<Transaction>();
        }

        public int AccountId { get; set; }
        public required string AccountName { get; set; }
        public decimal Balance { get; set; }
        public required string AccountType { get; set; }
        
        // Foreign key to link account to a user
        public required string ApplicationUserId { get; set; }

        // Navigation property to the user who owns this account
        public ApplicationUser? ApplicationUser { get; set; }

        // Collection of all transactions for this account
        public ICollection<Transaction> Transactions { get; set; }
    }
} 