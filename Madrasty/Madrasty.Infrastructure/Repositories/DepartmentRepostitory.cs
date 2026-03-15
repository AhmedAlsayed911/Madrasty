using Madrasty.Domain.Entities;
using Madrasty.Infrastructure.Abstracts;
using Madrasty.Infrastructure.Data;
using Madrasty.Infrastructure.InfrastructureBases;
using Microsoft.EntityFrameworkCore;

namespace Madrasty.Infrastructure.Repositories
{
    public class DepartmentRepostitory : GenericRepositoryAsync<Department>, IDepartmentRepostitory
    {
        private DbSet<Department> Departments;
        public DepartmentRepostitory(ApplicationDbContext dbContext) : base(dbContext)
        {
            Departments = dbContext.Set<Department>();
        }
    }
}
