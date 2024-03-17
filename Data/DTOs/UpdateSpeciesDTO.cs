using System.ComponentModel.DataAnnotations;
using TierZooAPI.Models;

namespace TierZooAPI.Data.DTOs;

public class UpdateSpeciesDTO
{
    [Required(ErrorMessage = "Name of the Specie is mandatory")]
    [StringLength(50)]
    public string speciesName { get; set; }

    public bool hermaphrodite { get; set; }

    public virtual ICollection<Genre> Genre { get; set; }
    //public virtual ICollection<Perk> perks { get; set; }
}
