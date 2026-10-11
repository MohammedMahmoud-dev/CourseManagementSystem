using AutoMapper;
using CourseManagementSystem.Application.DTOs.ClassGroup;
using CourseManagementSystem.Domain.Models;
namespace CourseManagementSystem.Application.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<ClassGroup, ClassGroupListDto>()
                   .ForMember(dest => dest.Level,
                              opt => opt.MapFrom(src => src.Level.ToString())) // Convert enum to string
                   .ForMember(dest => dest.StudentCount,
                              opt => opt.MapFrom(src => src.Students.Count)); // Get the count of students
        }
    }
}
