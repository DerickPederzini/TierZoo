using System.ComponentModel.DataAnnotations;

namespace TierZooAPI.Data.DTOs;

public class CreatePerkDTO
{
    [Required]
    [StringLength(50)]
    public string perkName { get; set; }

    [Required]
    [StringLength(125)]
    public string perkDescription { get; set; }

    public int SpeciesId { get; set; }
}
