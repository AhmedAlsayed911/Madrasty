using Madrasty.Core.Features.Students.Commands.Models;
using Madrasty.Domain.Entities;

namespace Madrasty.Core.Mapping.Students
{
    public partial class StudentProfile
    {
        public void EditStudentCommandMapping()
        {
            CreateMap<EditStudentCommand, Student>()
                .ForMember(i => i.StudID, opt => opt.MapFrom(i => i.Id))
                .ForMember(d => d.DID, opt => opt.MapFrom(d => d.DepartmentId));
        }
    }
}
