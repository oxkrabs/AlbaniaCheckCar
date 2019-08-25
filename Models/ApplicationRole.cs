using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace AlbaniaCheckCar.Models
{
    public class ApplicationRole : IdentityRole
    {
        public ApplicationRole()
        {}
        public ApplicationRole(string name) : base(name)
        {}
        
        public bool CanDelete { get; set; }
        
        public virtual ICollection<IdentityUserRole<string>> Users { get; } = new List<IdentityUserRole<string>>();
    }
}