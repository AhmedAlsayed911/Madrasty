using Madrasty.Domain.Entities;
using Madrasty.Infrastructure.Abstracts;
using Madrasty.Infrastructure.Data;
using Madrasty.Infrastructure.InfrastructureBases;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Madrasty.Infrastructure.Repositories
{
    public class StudentRepostitory : GenericRepositoryAsync<Student> ,IStudentRepostitory
    {
        private readonly DbSet<Student> students;
        public StudentRepostitory(ApplicationDbContext dbContext) : base(dbContext)
        {
            students = dbContext.Students;
        }
        public async Task<List<Student>> GetStudentsListAsync() => await students.ToListAsync();
        //public async Task<Student> GetStudentByIdAsync(int id) => await students.FindAsync(id);

    }
}
