using Madrasty.Domain.Entities;
using Madrasty.Infrastructure.InfrastructureBases;
using System;
using System.Collections.Generic;
using System.Text;

namespace Madrasty.Infrastructure.Abstracts
{
    public interface IStudentRepostitory : IGenericRepositoryAsync<Student>
    {
        Task<List<Student>> GetStudentsListAsync();
        //Task<Student> GetStudentByIdAsync(int id);
    }
}
