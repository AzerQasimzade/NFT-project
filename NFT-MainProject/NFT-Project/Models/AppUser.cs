using Microsoft.AspNetCore.Identity;

namespace NFT_Project.Models
{
    public class AppUser:IdentityUser
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public GenderHelper Gender { get; set; }
    }
}
