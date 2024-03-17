using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using TierZooAPI.Data;
using TierZooAPI.Data.DTOs;
using TierZooAPI.Models;

namespace TierZoo.Controllers;

[ApiController]
[Route("[controller]")]
public class SpecieController : ControllerBase
{
    private TierZooContext _context;
    private IMapper _mapper;

    public SpecieController(TierZooContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    [HttpPost]
    public IActionResult AddSpecies([FromBody] CreateSpecieDTO specieDTO)
    {
        Species specie = _mapper.Map<Species>(specieDTO);

        _context.Add(specie);

        _context.SaveChanges();

        return CreatedAtAction(nameof(RecoverSpeciesById), new { id = specie.Id }, specie);
    }

    [HttpGet]
    public IEnumerable<Species> RecoverSpecies(int skip = 0, int take = 30)
    {
        return _context.Species.Skip(skip).Take(take);
    }

    [HttpGet("{id}")]
    public IActionResult RecoverSpeciesById(int id)
    {
        var specie = _context.Species.FirstOrDefault(specie => specie.Id == id);
        if (specie == null) return NotFound();

        var specieDTO = _mapper.Map<ReadSpeciesDTO>(specie);

        return Ok(specie);
    }

    [HttpPut("{id}")]
    public IActionResult UpdateSpecies(int id, [FromBody] UpdateSpeciesDTO speciesDTO)
    {
        var specie = _context.Species.FirstOrDefault(species => species.Id == id);

        if (specie == null) return NotFound();

        _mapper.Map(speciesDTO, specie);

        _context.SaveChanges();

        return NoContent();
    }

    [HttpPatch("{id}")]
    public IActionResult UpdateSpeciesByPatch(int id, JsonPatchDocument<UpdateSpeciesDTO> speciesPatch)
    {
        var specie = _context.Species.FirstOrDefault(species => species.Id == id);

        if (specie == null) return NotFound();

        var updatedSpecies = _mapper.Map<UpdateSpeciesDTO>(specie);

        speciesPatch.ApplyTo(updatedSpecies, ModelState);

        if (!TryValidateModel(updatedSpecies)) return ValidationProblem();

        _mapper.Map(updatedSpecies, specie);

        _context.SaveChanges();

        return NoContent();
    }


}
