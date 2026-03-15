using Madrasty.Core.Features.Department.Queries.Results;
using Madrasty.Domain.Entities;

namespace Madrasty.Core.Mapping.Department
{
    public partial class DepartmentProfile
    {
        public void GetDeprtmentByIdMapping()
        {
            CreateMap<Madrasty.Domain.Entities.Department, GetDepartmentByIdResponse>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.DID))
                .ForMember(dest => dest.ManagerName, opt => opt.MapFrom(src => src.Instructor.Name))
                .ForMember(dest => dest.SubjectsList, opt => opt.MapFrom(src => src.DepartmentSubjects))
                //.ForMember(dest => dest.StudentsList, opt => opt.MapFrom(src => src.Students))
                .ForMember(dest => dest.InstructorsList, opt => opt.MapFrom(src => src.Instructors));

            CreateMap<DepartmentSubject, SubjectResponse>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(d => d.SubID))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(d => d.Subject.Name));

            //CreateMap<Student, StudentResponse>()
            //    .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.StudID))
            //    .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name));

            CreateMap<Instructor, InstructorResponse>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.InsId))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name));
        }
    }
}
