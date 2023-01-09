using Microsoft.AspNetCore.Identity;

namespace AutofacTest.Data.Entities
{
    public class User : IdentityUser<int>
    {
        public int Id { get; set; }
    }
}
