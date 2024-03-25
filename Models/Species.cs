using System.ComponentModel.DataAnnotations;

namespace TierZooAPI.Models;

public class Species
{
    [Key]
    [Required]
    public int Id { get; set; }
    [Required(ErrorMessage = "Name of the Specie is necessary")]
    [StringLength(50)]
    public string specieName { get; set; }

    public bool hermaphrodite { get; set; }

    public virtual ICollection<Genre> Genre { get; set; }

    public virtual ICollection<Perk> perks { get; set; }

    public virtual ICollection<User> Users { get; set; }
}