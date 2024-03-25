using AutoMapper;
using TierZooAPI.Data.DTOs;
using TierZooAPI.Models;

namespace TierZooAPI.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile() {
            
            CreateMap<CreateUserDTO, User>();
        
        }
    }
}
