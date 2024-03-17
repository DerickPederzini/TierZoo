using AutoMapper;

using TierZooAPI.Data.DTOs;
using TierZooAPI.Models;

namespace TierZooAPI.Profiles;

public class SpeciesProfile : Profile
{
    public SpeciesProfile()
    {
        //used in a Post Method (Create)
        CreateMap<CreateSpecieDTO, Species>();

        //Used in a Patch Method (Update)
        CreateMap<Species, UpdateSpeciesDTO>();

        //Used in a Get (Not by Id) Method (Read)
        CreateMap<Species, ReadSpeciesDTO>();

        //Used in a Put Method (Update)
        CreateMap<UpdateSpeciesDTO, Species>();
    }
}
