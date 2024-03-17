using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using TierZooAPI.Data;
using TierZooAPI.Data.DTOs;
using TierZooAPI.Models;

namespace TierZooAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class GenreController : ControllerBase
{
    TierZooContext _context;
    IMapper _mapper;

    public GenreController(TierZooContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    [HttpPost]
    public IActionResult AddGenre(CreateGenreDTO genreDTO)
    {
        var genre = _mapper.Map<Genre>(genreDTO);

        _context.Add(genre);

        _context.SaveChanges();

        return CreatedAtAction(nameof(RecoverGenreById), new { id = genre.Id}, genre);
    }

    [HttpGet]
    public IEnumerable<Genre> RecoverGenre(int skip = 0, int take = 50)
    {
        return _context.Genre.Skip(skip).Take(take);
    }

    [HttpGet("{id}")]
    public IActionResult RecoverGenreById(int id)
    {
        var genre = _context.Genre.FirstOrDefault(genre => genre.Id == id);

        if(genre == null) { return NotFound(); }

        var genreDTO = _mapper.Map<ReadGenreDTO>(genre);

        return Ok(genre);
    }

    [HttpPut("{id}")]
    public IActionResult UpdateGenre(int id, [FromBody] UpdateGenreDTO genreDTO)
    {

        var genre = _context.Genre.FirstOrDefault(genres => genres.Id == id);

        if(genre == null) { return NotFound();  }

        _mapper.Map(genreDTO, genre);

        _context.SaveChanges();

        return NoContent();
    }

    [HttpPatch("{id}")]
    public IActionResult UpdateGenreByPatch(int id, JsonPatchDocument<UpdateGenreDTO> genrePatch)
    {
        var genre = _context.Genre.FirstOrDefault(genres => genres.Id == id);

        if(genre == null) { return NotFound();  }

        var genreUpdated = _mapper.Map<UpdateGenreDTO>(genre);

        genrePatch.ApplyTo(genreUpdated, ModelState);

        if(!TryValidateModel(genreUpdated)) { return ValidationProblem(); }

        _mapper.Map(genreUpdated, genre);

        _context.SaveChanges();

        return NoContent();
    }




}
