using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace TierZooAPI.Models
{
    public class User : IdentityUser
    {

        [Required]
        public int SpeciesId { get; set; }
        public virtual Species Species { get; set; }

        [Required]
        public int GenreId { get; set; }
        public virtual Genre Genre { get; set; }


        [Required]
        public int PerkId { get; set; }
        public virtual Perk Perk { get; set; }

        public User() : base () 
        { 
        
        }
    }
}
