using Madrasty.Core.Features.Students.Commands.Models;
using Madrasty.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Madrasty.Core.Mapping.Students
{
    public partial class StudentProfile
    {
        public void AddStudentCommandMapping()
            => CreateMap<AddStudentCommand, Student>()
            .ForMember(dest => dest.DID, opt => opt.MapFrom(d => d.DepartmentId));           
    }
}
