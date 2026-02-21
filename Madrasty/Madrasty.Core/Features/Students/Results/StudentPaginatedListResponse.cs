namespace Madrasty.Core.Features.Students.Results
{
    public class StudentPaginatedListResponse
    {
        public int StudID { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }

        public string? DepartmentName { get; set; }

        public StudentPaginatedListResponse(int studId, string name, string address, string departmentName)
        {
            StudID = studId;
            Name = name;
            Address = address;
            DepartmentName = departmentName;
        }

    }
}
