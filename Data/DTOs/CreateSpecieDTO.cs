using System.ComponentModel.DataAnnotations;
using TierZooAPI.Models;

namespace TierZooAPI.Data.DTOs;

public class CreateSpecieDTO
{
    [Required(ErrorMessage = "Name of the Specie is mandatory")]
    [StringLength(50)]
    public string specieName { get; set; }
    public bool hermaphrodite { get; set; }
}