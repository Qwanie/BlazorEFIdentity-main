using Microsoft.AspNetCore.Identity;

namespace BlazorEFIdentity.Data
{
    // Extends IdentityUser to add custom user properties
    public class ApplicationUser : IdentityUser
    {
        // Constructor initializes the Accounts collection
        public ApplicationUser()
        {
            Accounts = new List<Account>();
        }

        // Required user first name
        public required string FirstName { get; set; }

        // Required user last name
        public required string LastName { get; set; }

        // User's date of birth
        public DateTime DateOfBirth { get; set; }

        // Collection of accounts owned by this user
        public ICollection<Account> Accounts { get; set; }
    }
}
