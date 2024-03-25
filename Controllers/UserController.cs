using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TierZooAPI.Data;
using TierZooAPI.Data.DTOs;
using TierZooAPI.Models;
using TierZooAPI.Profiles;



namespace TierZooAPI.Controllers;

[ApiController]
[Route("[Controller]")]
public class UserController : ControllerBase
{
    private IMapper _mapper;
    private UserManager<User> _userContext;

    public UserController(IMapper mapper, UserManager<User> userContext)
    {
        _mapper = mapper;
        _userContext = userContext;
    }

    [HttpPost]
    public async Task<IActionResult> AddUserAsync(CreateUserDTO userDTO)
    {
        User user = _mapper.Map<User>(userDTO);

        IdentityResult result = await _userContext.CreateAsync(user, userDTO.Password);

        if (result.Succeeded)
        {
            return Ok("User signed in!");
        }

        throw new ApplicationException("Failed do Add User!");

    }
    
}
