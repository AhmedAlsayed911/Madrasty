using Madrasty.Core.Wrappers;

namespace Madrasty.Core.Features.Department.Queries.Results
{
    public class GetDepartmentByIdResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ManagerName { get; set; }
        public PaginatedResult<StudentResponse>? StudentsList { get; set; }
        public List<SubjectResponse>? SubjectsList { get; set; }
        public List<InstructorResponse>? InstructorsList { get; set; }
    }
    public class StudentResponse
    {
        public StudentResponse(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public class SubjectResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public class InstructorResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
