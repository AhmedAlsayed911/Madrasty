using Madrasty.Domain.Entities;
using Madrasty.Domain.Helpers;
using Madrasty.Infrastructure.Abstracts;
using Madrasty.Service.Abstracts;
using Microsoft.EntityFrameworkCore;

namespace Madrasty.Service.Services
{
    public class StudentService(IStudentRepostitory studentRepostitory) : IStudentService
    {

        public async Task<List<Student>> GetStudentsListAsync() => await studentRepostitory.GetStudentsListAsync();
        public async Task<Student> GetStudentByIdAsync(int id)  //=> await studentRepostitory.GetByIdAsync(id);
        {
            var student = studentRepostitory.GetTableNoTracking()
                .Where(x => x.StudID.Equals(id))
                .FirstOrDefault();

            return student;
        }

        public async Task<string> AddStudentAsync(Student student)
        {
            await studentRepostitory.AddAsync(student);

            return "Success";
        }

        public async Task<bool> IsNameExist(string name)
        {
            var checkStudent = studentRepostitory.GetTableNoTracking()
                                .Where(x => x.Name.Equals(name)).FirstOrDefault();

            if (checkStudent is null) return false;

            return true;
        }

        public async Task<bool> IsNameExistExcludeSelf(string name, int id)
        {
            var checkStudent = await studentRepostitory.GetTableNoTracking()
                .Where(x => x.Name.Equals(name) & !x.StudID.Equals(id)).SingleOrDefaultAsync();

            if (checkStudent is null) return false;

            return true;
        }

        public async Task<string> EditAsync(Student student)
        {
            await studentRepostitory.UpdateAsync(student);

            return "Success";
        }

        public async Task<string> DeleteAsync(Student student)
        {
            var trans = studentRepostitory.BeginTransaction();

            try
            {
                await studentRepostitory.DeleteAsync(student);
                await trans.CommitAsync();
                return "Success";
            }
            catch
            {
                await trans.RollbackAsync();
                return "Failed";
            }


        }

        public IQueryable<Student> GetStudentsQueryable()
        {
            return studentRepostitory.GetTableNoTracking().AsQueryable();
        }

        public IQueryable<Student> FilterStudentPaginatedQuery(StudentOrderingEnum orderby, string search)
        {
            var queryable = studentRepostitory.GetTableNoTracking().AsQueryable();

            if (search is not null)
                queryable = queryable
                    .Where(x => x.Name.Contains(search) || x.Address.Contains(search));

            switch (orderby)
            {
                case StudentOrderingEnum.Id:
                    queryable = queryable.OrderBy(x => x.StudID);
                    break;
                case StudentOrderingEnum.Name:
                    queryable = queryable.OrderBy(x => x.Name);
                    break;
                case StudentOrderingEnum.Address:
                    queryable = queryable.OrderBy(x => x.Address);
                    break;
                case StudentOrderingEnum.DepartmentName:
                    queryable = queryable.OrderBy(x => x.Department.Name);
                    break;
                default:
                    return queryable;
            }

            return queryable;
        }

        public IQueryable<Student> GetStudentsByDepartmentIdQueryable(int id)
        {
            return studentRepostitory.GetTableNoTracking().Where(i => i.DID == id).AsQueryable();
        }
    }
}
