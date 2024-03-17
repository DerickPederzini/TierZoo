using System.ComponentModel.DataAnnotations;

namespace TierZooAPI.Data.DTOs;

public class UpdatePerkDTO
{
    [Required]
    [StringLength(50)]
    public string perkName { get; set; }

    [Required]
    [StringLength(125)]
    public string perkDescription { get; set; }

    public int SpecieId { get; set; }

}
