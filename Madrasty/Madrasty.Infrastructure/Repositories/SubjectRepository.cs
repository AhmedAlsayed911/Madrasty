using Madrasty.Domain.Entities;
using Madrasty.Infrastructure.Abstracts;
using Madrasty.Infrastructure.Data;
using Madrasty.Infrastructure.InfrastructureBases;
using Microsoft.EntityFrameworkCore;

namespace Madrasty.Infrastructure.Repositories
{
    public class SubjectRepository : GenericRepositoryAsync<Subject>, ISubjectRepostitory

    {
        private DbSet<Subject> Subjects;
        public SubjectRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            Subjects = dbContext.Set<Subject>();
        }
    }
}
