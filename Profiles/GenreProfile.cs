using AutoMapper;
using TierZooAPI.Data.DTOs;
using TierZooAPI.Models;

namespace TierZooAPI.Profiles;

public class GenreProfile : Profile
{
    public GenreProfile() 
    {
        //Used in an Post Method (Create)
        CreateMap<CreateGenreDTO, Genre>();

        //Used in a Patch Mehotd (Update Parcially)
        CreateMap<Genre, UpdateGenreDTO>();

        //Used in a Get Method (Not By Id) (Read)
        CreateMap<Genre, ReadGenreDTO>();

        //Used in a Put Method (Update)
        CreateMap<UpdateGenreDTO, Genre>();
    }
}
