using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace TierZooAPI.Models
{
    public class User : IdentityUser
    {
        [Required]
        public virtual Species Species { get; set; }
        [Required]
        public virtual Genre Genre { get; set; }
        [Required]
        public virtual Perk Perk { get; set; }

        public User() : base () 
        { 
        
        }
    }
}
