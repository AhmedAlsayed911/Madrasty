using Madrasty.Core.Features.Students.Results;
using Madrasty.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Madrasty.Core.Mapping.Students
{
    public partial class StudentProfile
    {
        public void GetStudentListMapping()
        => CreateMap<Student, StudentListResponse>()
            .ForMember(dest => dest.DepartmentName, opt => opt.MapFrom(src => src.Department.DName));
    }
}
