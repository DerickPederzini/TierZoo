using AutoMapper;
using Microsoft.AspNetCore.Identity;
using TierZooAPI.Data.DTOs;
using TierZooAPI.Models;

namespace TierZooAPI.Services
{
    public class SignInService
    {
        private IMapper _mapper;
        private UserManager<User> _userManager;

        public SignInService(IMapper mapper, UserManager<User> userManager)
        {
            _mapper = mapper;
            _userManager = userManager;
        }

        public async Task SignIn(CreateUserDTO userDTO)
        {
            User user = _mapper.Map<User>(userDTO);

            IdentityResult result = await _userManager.CreateAsync(user, userDTO.Password);

            if (!result.Succeeded)
                throw new ApplicationException("Failed do Add User!");
            
            return;
        }
    }
