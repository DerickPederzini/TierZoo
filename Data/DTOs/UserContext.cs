using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TierZooAPI.Models;

namespace TierZooAPI.Data.DTOs
{
    public class UserContext : IdentityDbContext<User>
    {
        public UserContext(DbContextOptions<UserContext> options) : base(options) 
        { 
        
        }   

    }
}
