using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using TierZooAPI.Data;
using TierZooAPI.Data.DTOs;
using TierZooAPI.Models;

namespace TierZooAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class PerkController : ControllerBase
{
    TierZooContext _context;
    IMapper _mapper;

    public PerkController(TierZooContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    [HttpPost]
    public IActionResult AddPerk(CreatePerkDTO perkDTO)
    {
        var perk = _mapper.Map<Perk>(perkDTO);

        _context.Add(perk);

        _context.SaveChanges();

        return CreatedAtAction(nameof(RecoverPerkById), new { id = perk.Id }, perk);
    }

    [HttpGet]
    public IEnumerable<Perk> RecoverPerk(int skip = 0, int take = 50)
    {
        return _context.Perk.Skip(skip).Take(take);
    }

    [HttpGet("{id}")]
    public IActionResult RecoverPerkById (int id)
    {
        var perk = _context.Perk.FirstOrDefault(perk => perk.Id == id);

        if (perk == null) { return NotFound(); }

        var perkDTO = _mapper.Map<ReadPerkDTO>(perk);

        return Ok(perk);
    }

    [HttpPut("{id}")]
    public IActionResult UpdatePerk(int id, [FromBody] UpdatePerkDTO perkDTO)
    {
        var perk = _context.Perk.FirstOrDefault(perks => perks.Id == id);

        if(perk == null) { return NotFound(); }

        _mapper.Map(perkDTO, perk);

        _context.SaveChanges();

        return NotFound();
    }

    [HttpPatch("{id}")]
    public IActionResult UpdatePerkByPatch(int id, JsonPatchDocument<UpdatePerkDTO> perkPatch) 
    {
        var perk = _context.Perk.FirstOrDefault(perks => perks.Id == id);

        if (perk == null) { return NotFound(); }

        var perkUpdated = _mapper.Map<UpdatePerkDTO>(perk);

        perkPatch.ApplyTo(perkUpdated, ModelState);

        if (!TryValidateModel(perkUpdated)) { return ValidationProblem(); }

        _mapper.Map(perkUpdated, perk);

        _context.SaveChanges();

        return Ok();
    }

}
