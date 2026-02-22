using Madrasty.Domain.Entities;
using Madrasty.Domain.Helpers;

namespace Madrasty.Service.Abstracts
{
    public interface IStudentService
    {
        public Task<List<Student>> GetStudentsListAsync();
        public Task<Student> GetStudentByIdAsync(int id);
        public Task<string> AddStudentAsync(Student student);
        public Task<bool> IsNameExist(string name);
        public Task<bool> IsNameExistExcludeSelf(string name, int id);
        public Task<string> EditAsync(Student student);
        public Task<string> DeleteAsync(Student student);
        public IQueryable<Student> GetStudentsQueryable();
        public IQueryable<Student> FilterStudentPaginatedQuery(StudentOrderingEnum orderBy, string search);
    }
}
