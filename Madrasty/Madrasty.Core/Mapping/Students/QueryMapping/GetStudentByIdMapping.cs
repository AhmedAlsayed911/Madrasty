using Madrasty.Core.Features.Students.Results;
using Madrasty.Domain.Entities;

namespace Madrasty.Core.Mapping.Students
{
    public partial class StudentProfile
    {
        public void GetStudentByIdMapping()
            => CreateMap<Student, SingleStudentResponse>()
            .ForMember(dest => dest.DepartmentName, opt => opt.MapFrom(src => src.Department.Name));
    }
}
