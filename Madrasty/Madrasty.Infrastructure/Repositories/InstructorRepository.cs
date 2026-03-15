using Madrasty.Domain.Entities;
using Madrasty.Infrastructure.Abstracts;
using Madrasty.Infrastructure.Data;
using Madrasty.Infrastructure.InfrastructureBases;
using Microsoft.EntityFrameworkCore;

namespace Madrasty.Infrastructure.Repositories
{
    public class InstructorRepository : GenericRepositoryAsync<Instructor>, IINstructorRepostitory
    {
        private DbSet<Instructor> Instructors;
        public InstructorRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            Instructors = dbContext.Set<Instructor>();
        }
    }
}
