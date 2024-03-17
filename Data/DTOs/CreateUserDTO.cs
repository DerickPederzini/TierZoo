using System.ComponentModel.DataAnnotations;
using TierZooAPI.Models;

namespace TierZooAPI.Data.DTOs
{
    public class CreateUserDTO
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string ConfirmPassword { get; set; }


        [Required]
        public int SpeciesId { get; set; }
        [Required] 
        public int GenreId { get; set; }
        [Required]
        public int PerkId { get; set; }
    }
}
