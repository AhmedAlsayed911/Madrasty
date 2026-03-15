using Madrasty.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Madrasty.Infrastructure.Configurations
{
    public class InstructorConfigurations : IEntityTypeConfiguration<Instructor>
    {
        public void Configure(EntityTypeBuilder<Instructor> builder)
        {
            builder
                .HasOne(s => s.Supervisor)
                .WithMany(s => s.Instructors)
                .HasForeignKey(k => k.SupervisorId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
