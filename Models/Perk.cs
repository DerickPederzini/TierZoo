using System.ComponentModel.DataAnnotations;

namespace TierZooAPI.Models;

public class Perk
{
    [Key]
    [Required]
    public int Id { get; set; }

    [Required(ErrorMessage = "A name for the Perk is mandatory")]
    [StringLength(50)]
    public string perkName { get; set; }

    [Required(ErrorMessage = "Give at least a little bit of context for the perk")]
    [StringLength(125)]
    public string perkDescription { get; set; }

    [Required]
    public int SpeciesId { get; set; }
    public virtual Species Species { get; set; }

    public virtual ICollection<User> users { get; set; }


}
