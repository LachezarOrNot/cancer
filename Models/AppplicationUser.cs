using Microsoft.AspNetCore.Identity;

namespace EffiSenseRe.Models {
    public class ApplicationUser : IdentityUser {
        public ICollection<Home> Homes { get; set; }
    }
}
