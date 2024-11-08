using AutoMapper;
using ScheduleTime.CrossCutting.DTOs.V1;
using ScheduleTime.Domain.Entities;

namespace ScheduleTime.CrossCutting.ProfileMapper
{
    public class BeautySalonMapper : Profile
    {
        public BeautySalonMapper()
        {
            CreateMap<BeautySalon, BeautySalonDTO>()
                .ForMember(dest => dest.Hair, opt => 
                    opt.MapFrom(src => src.Hair))
                .ForMember(dest => dest.Nail, opt => 
                    opt.MapFrom(src => src.Nail))
                .ForMember(dest => dest.Lash, opt => 
                    opt.MapFrom(src => src.Lash))
                .ForMember(dest => dest.AnotherProcedure, opt => 
                    opt.MapFrom(src => src.AnotherProcedure))
                .ForMember(dest => dest.Schedule, opt => 
                    opt.MapFrom(src => src.Schedule))
                .ReverseMap();
        }
    }
}
