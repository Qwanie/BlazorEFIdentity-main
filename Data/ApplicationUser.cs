using Microsoft.AspNetCore.Identity;

namespace BlazorEFIdentity.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public ApplicationUser()
        {
            Accounts = new List<Account>();
        }

        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public ICollection<Account> Accounts { get; set; } // Assuming you have an Account class
    }

}
