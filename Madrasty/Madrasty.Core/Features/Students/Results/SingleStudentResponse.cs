using System;
using System.Collections.Generic;
using System.Text;

namespace Madrasty.Core.Features.Students.Results
{
    public class SingleStudentResponse
    {
        public int StudID { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }
        public string? DepartmentName { get; set; }
    }
}
