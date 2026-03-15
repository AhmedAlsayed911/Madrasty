using Madrasty.Domain.Entities;
using Madrasty.Infrastructure.Abstracts;
using Madrasty.Service.Abstracts;
using Microsoft.EntityFrameworkCore;

namespace Madrasty.Service.Services
{
    public class DepartmentService(IDepartmentRepostitory repostitory)
        : IDepartmentService
    {
        public async Task<Department> GetDepartmentByid(int id)
        {
            var result = await
                repostitory
                .GetTableNoTracking()
                .Where(i => i.DID.Equals(id))
                .FirstOrDefaultAsync();

            return result;
        }
    }
}
