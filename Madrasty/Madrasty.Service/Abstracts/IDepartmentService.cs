using Madrasty.Domain.Entities;

namespace Madrasty.Service.Abstracts
{
    public interface IDepartmentService
    {
        Task<Department> GetDepartmentByid(int id);
    }
}
