using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TierZooAPI.Data;
using TierZooAPI.Data.DTOs;
using TierZooAPI.Models;
using TierZooAPI.Profiles;
using TierZooAPI.Services;



namespace TierZooAPI.Controllers;

[ApiController]
[Route("[Controller]")]
public class UserController : ControllerBase
{

    private SignInService _signInService;

    public UserController(SignInService signInService)
    {
        _signInService = signInService;
    }

    [HttpPost]
    public async Task<IActionResult> AddUserAsync(CreateUserDTO userDTO)
    {

        await _signInService.SignIn(userDTO);

        return Ok("User signed in!");
        

    }
    
}
