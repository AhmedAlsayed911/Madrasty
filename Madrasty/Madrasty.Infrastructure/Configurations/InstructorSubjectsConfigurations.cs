using Madrasty.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Madrasty.Infrastructure.Configurations
{
    public class InstructorSubjectsConfigurations : IEntityTypeConfiguration<InstructorSubjects>
    {
        public void Configure(EntityTypeBuilder<InstructorSubjects> builder)
        {
            builder
                .HasKey(k => new { k.InsId, k.SubId });
        }
    }
}
