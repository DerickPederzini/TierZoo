using AutoMapper;
using TierZooAPI.Data;
using TierZooAPI.Data.DTOs;
using TierZooAPI.Models;

namespace TierZooAPI.Profiles;

public class PerkProfile : Profile
{
    public PerkProfile()
    {
        //Used in an Post Method (Create)
        CreateMap<CreatePerkDTO, Perk>();

        //Used in a Patch Method (Update Parcially)
        CreateMap<Perk, UpdatePerkDTO>();

        //Used in a Get Method(Not by Id) (Read)
        CreateMap<Perk, ReadPerkDTO>();
        
        //Used in a Put Method (Update)
        CreateMap<UpdatePerkDTO, Perk>();
    }


}
