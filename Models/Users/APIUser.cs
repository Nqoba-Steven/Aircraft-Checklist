using Microsoft.AspNetCore.Identity;
namespace NAC_Aircraft_Checklist.Models.Users
{
    public class APIUser: IdentityUser
    {
        public string Name { get; set; }
        public string EmailAddress { get; set; }
    }
}
