using Microsoft.AspNetCore.Identity;
using System;

namespace PaymentPlatformAPI.Models
{
    public class ApplicationUser : IdentityUser
    {
        // profile fields
        public string FullName { get; set; } = string.Empty;
        public string DisplayName { get; set; } = string.Empty;
        // Track when the account was created
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        // Simple balance field for demo purposes (consider using a separate ledger in production)
        public decimal Balance { get; set; } = 0m;
    }
}
