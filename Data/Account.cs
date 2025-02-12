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
        
        // Navigation property to ApplicationUser
        public required string ApplicationUserId { get; set; }
        public ApplicationUser? ApplicationUser { get; set; }

        // Collection of transactions
        public ICollection<Transaction> Transactions { get; set; }
    }
} 