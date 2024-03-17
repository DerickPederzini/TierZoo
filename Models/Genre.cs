using System.ComponentModel.DataAnnotations;

namespace TierZooAPI.Models;

public class Genre
{
    [Required]
    public int Id { get; set; }
    [Required(ErrorMessage ="Name of the Genre is mandatory")]
    [StringLength(50)]
    public string name { get; set; }
    [Required(ErrorMessage = "Points of inteligence are mandatory")]
    public double inteligence {  get; set; }
    [Required(ErrorMessage = "Points of power are mandatory")]
    public double power { get; set; }
    [Required(ErrorMessage = "Points of defense are mandatory")]
    public double defense { get; set; }
    [Required(ErrorMessage = "Points of speed are mandatory")]
    public double speed { get; set; }
    [Required(ErrorMessage = "Points of health are mandatory")]
    public double health { get; set; }
    [Required(ErrorMessage = "Points of camouflage are mandatory")]
    public double camouflage { get; set; }
    [Required]
    public int SpeciesId { get; set; }
    public virtual Species Species { get; set; }


}