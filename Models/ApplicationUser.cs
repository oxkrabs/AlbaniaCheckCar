using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlbaniaCheckCar.Models
{
    public class ApplicationUser : IdentityUser
    {
        public ApplicationUser() : base()
        {
            CreatedAt = DateTime.UtcNow;
        }

        public ApplicationUser(string name) : base(name)
        {
            CreatedAt = DateTime.UtcNow;
        }
        
        public DateTime CreatedAt { get; set; }
        public virtual ICollection<IdentityUserRole<string>> Roles { get; } = new List<IdentityUserRole<string>>();
    }
}